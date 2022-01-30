// -----------------------------------------------------------------
// <copyright file="CompositionRootExtensions.cs" company="The Fibula Project">
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
    using System.IO;
    using Fibula.Utilities.Validation;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Static class that adds convenient methods to add the concrete implementations contained in this library.
    /// </summary>
    public static class CompositionRootExtensions
    {
        /// <summary>
        /// Adds all concrete class implementations contained in this library to the services collection.
        /// </summary>
        /// <param name="services">The services collection.</param>
        /// <param name="forStream">The stream to add the listener for.</param>
        public static void AddInputStreamListener(this IServiceCollection services, Stream forStream)
        {
            Validate.ThrowIfNull(forStream);

            services.AddSingleton(new InputStreamReaderListener(forStream));
            services.AddHostedService((s) => s.GetService<InputStreamReaderListener>());
        }
    }
}
