using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public abstract class MemoryItem
    {
        // consider implementing IComparable?
        public abstract bool Compare(MemoryItem compareTo);

        /// <summary>
        /// Generates a random MemoryItem
        /// </summary>
        public abstract void GenerateItem();
    }
}