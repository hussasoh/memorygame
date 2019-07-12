using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class MemoryImage: MemoryItem
    {
        private string _imageFile;
        private string _imageName;

        override public bool Compare(MemoryItem compareTo)
        {
            bool same = true;

            return same;
        }

        override public void GenerateItem()
        {
            // temp code
            
        }
    }
}