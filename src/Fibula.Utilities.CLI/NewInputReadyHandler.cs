// -----------------------------------------------------------------
// <copyright file="NewInputReadyHandler.cs" company="The Fibula Project">
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
    /// Delegate to handle a call when new input is ready.
    /// </summary>
    /// <param name="line">The new, raw input.</param>
    public delegate void NewInputReadyHandler(string line);
}
