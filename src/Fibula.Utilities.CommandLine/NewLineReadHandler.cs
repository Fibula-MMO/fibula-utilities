// -----------------------------------------------------------------
// <copyright file="NewLineReadHandler.cs" company="The Fibula Project">
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
    /// Delegate to handle a call when a new line has been read.
    /// </summary>
    /// <param name="line">The line that was read.</param>
    public delegate void NewLineReadHandler(string line);
}
