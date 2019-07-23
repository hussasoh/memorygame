using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    /// <summary>
    /// Abstract class that all memory items must inherit from
    /// </summary>
    public abstract class MemoryItem: IComparable<MemoryItem>
    {
        /// <summary>
        /// Compares another MemoryItem to this MemoryItem
        /// </summary>
        /// <param name="compareTo">MemoryItem to compare this item to</param>
        /// <returns>0 if they are the same, 1 if they are different</returns>
        public abstract int CompareTo(MemoryItem compareTo);

        /// <summary>
        /// Generates a random MemoryItem.
        /// </summary>
        public abstract void GenerateItem();
    }
}