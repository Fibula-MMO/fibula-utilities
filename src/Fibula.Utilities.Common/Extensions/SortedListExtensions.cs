// -----------------------------------------------------------------
// <copyright file="SortedListExtensions.cs" company="2Dudes">
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
    using System.Collections.Generic;

    /// <summary>
    /// Extension methods to make the System.Collections.Generic.SortedList easier to use.
    /// </summary>
    public static class SortedListExtensions
    {
        /// <summary>
        /// Checks if the SortedList is empty.
        /// </summary>
        /// <typeparam name="TKey">The type of key.</typeparam>
        /// <typeparam name="TValue">The type of value.</typeparam>
        /// <param name="sortedList">SortedList to check if it is empty.</param>
        /// <returns>True if sortedList is empty, false if it still has elements.</returns>
        public static bool IsEmpty<TKey, TValue>(this SortedList<TKey, TValue> sortedList)
        {
            return sortedList.Count == 0;
        }
    }
}
