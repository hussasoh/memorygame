using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class MemoryNumber: MemoryItem
    {
        private int _number;
        override public bool Compare(MemoryItem compareTo)
        {
            bool same = true;

            return same;
        }

        override public void GenerateItem()
        {
            // temp code
            this._number = 1;
        }
    }
}