// -----------------------------------------------------------------
// <copyright file="IInputListener.cs" company="The Fibula Project">
// Copyright (c) | The Fibula Project.
// https://github.com/orgs/fibula-mmo/people
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Utilities.CLI
{
    /// <summary>
    /// Interface for a listener for input.
    /// </summary>
    public interface IInputListener
    {
        /// <summary>
        /// Event raised when the listener has new input available.
        /// </summary>
        event NewInputReadyHandler NewLineRead;
    }
}
