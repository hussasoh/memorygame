using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class MemoryLetter: MemoryItem
    {
        private char _letter;

        override public bool Compare(MemoryItem compareTo)
        {
            bool same = true;

            return same;
        }

        override public void GenerateItem()
        {
            // temp code
            _letter = 'a';
        }
    }
}