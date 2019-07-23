using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    /// <summary>
    /// An image to memorize. Not complete, may scrap
    /// </summary>
    public class MemoryImage: MemoryItem
    {
        private string _imageFile;
        private string _imageName;

        override public int CompareTo(MemoryItem compareTo)
        {
            int same = 0;

            return same;
        }

        override public void GenerateItem()
        {
            // temp code
            
        }
    }
}