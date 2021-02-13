﻿// -----------------------------------------------------------------
// <copyright file="SortedListExtensions.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Utilities.Pathfinding.Extensions
{
    using System.Collections.Generic;
    using Fibula.Utilities.Pathfinding.Abstractions;

    /// <summary>
    /// Extension methods to make the System.Collections.Generic.SortedList easier to use.
    /// </summary>
    public static class SortedListExtensions
    {
        /// <summary>
        /// Adds a INode to the SortedList.
        /// </summary>
        /// <param name="sortedList">SortedList to add the node to.</param>
        /// <param name="node">Node to add to the sortedList.</param>
        public static void Add(this SortedList<int, INode> sortedList, INode node)
        {
            sortedList.Add(node.TotalCost, node);
        }

        /// <summary>
        /// Removes the node from the sorted list with the smallest TotalCost and returns that node.
        /// </summary>
        /// <param name="sortedList">SortedList to remove and return the smallest TotalCost node.</param>
        /// <returns>Node with the smallest TotalCost.</returns>
        public static INode Pop(this SortedList<int, INode> sortedList)
        {
            var top = sortedList.Values[0];

            sortedList.RemoveAt(0);

            return top;
        }
    }
}
