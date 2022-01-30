// -----------------------------------------------------------------
// <copyright file="InputStreamReaderListener.cs" company="The Fibula Project">
// Copyright (c) | The Fibula Project.
// https://github.com/orgs/fibula-mmo/people
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Utilities.CLI.Streams
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Fibula.Utilities.CLI;
    using Fibula.Utilities.Validation;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Class that implements a stream reader that constantly monitors a stream and raises events when a new line is read.
    /// </summary>
    public class InputStreamReaderListener : IInputListener, IHostedService
    {
        /// <summary>
        /// The stream that the reader is hooked up to.
        /// </summary>
        private readonly Stream stream;

        /// <summary>
        /// Initializes a new instance of the <see cref="InputStreamReaderListener"/> class.
        /// </summary>
        /// <param name="stream">The stream to monitor.</param>
        public InputStreamReaderListener(Stream stream)
        {
            Validate.ThrowIfNull(stream);

            this.stream = stream;
        }

        /// <summary>
        /// Event raised when the reader has read a new line.
        /// </summary>
        public event NewInputReadyHandler NewLineRead;

        /// <inheritdoc/>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Validate.ThrowIfNull(cancellationToken);

            var streamReader = new StreamReader(this.stream);

            Task.Run(
                async () =>
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        // Read from our stream and issue events when there is a new line.
                        try
                        {
                            var lineRead = await streamReader.ReadLineAsync();

                            this.NewLineRead?.Invoke(lineRead);
                        }
                        catch (Exception)
                        {
                        }
                    }
                },
                cancellationToken);

            // return this to allow other IHostedService-s to start.
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            this.NewLineRead = null;

            return Task.CompletedTask;
        }
    }
}
