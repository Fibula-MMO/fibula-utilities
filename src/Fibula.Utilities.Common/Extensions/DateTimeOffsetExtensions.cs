// -----------------------------------------------------------------
// <copyright file="TimeSpanExtensions.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Utilities.Common.Extensions
{
    using System;

    /// <summary>
    /// Static class that contains helper methods for <see cref="DateTimeOffset"/>s.
    /// </summary>
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Rounds the given datetime by a given timespan.
        /// </summary>
        /// <param name="dateTime">The datetime to round.</param>
        /// <param name="roundBy">The time span to round by.</param>
        /// <returns>The rounded time.</returns>
        public static DateTimeOffset Round(this DateTimeOffset dateTime, TimeSpan roundBy)
        {
            long remainderTicks = dateTime.Ticks % roundBy.Ticks;
            if (remainderTicks < roundBy.Ticks / 2)
            {
                // round down
                return dateTime.AddTicks(-remainderTicks);
            }

            // round up
            return dateTime.AddTicks(roundBy.Ticks - remainderTicks);
        }
    }
}
