// -----------------------------------------------------------------
// <copyright file="IInputReader.cs" company="The Fibula Project">
// Copyright (c) | The Fibula Project.
// https://github.com/orgs/fibula-mmo/people
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Utilities.CommandLine
{
    /// <summary>
    /// Interface for a reader that intends to read from a given input.
    /// </summary>
    public interface IInputReader
    {
        /// <summary>
        /// Event raised when the reader has read a new line.
        /// </summary>
        event NewLineReadHandler NewLineRead;
    }
}
