using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class MemoryShape: MemoryItem
    {
        private Shape _shape;

        public Shape Shape
        {
            get { return _shape; }
            set
            {
                if ((int)value >= 0 && (int)value <= 5)
                    _shape = value;
                else
                    throw new Exception("Not a valid Shape");
            }
        }

        /// <summary>
        /// Generates a random Shape
        /// </summary>
        override public void GenerateItem()
        {
            Random rand = new Random();
            int shapeNum = rand.Next(6);
            switch(shapeNum)
            {
                case 0:
                    Shape = Shape.CIRCLE;
                    break;
                case 1:
                    Shape = Shape.SQUARE;
                    break;
                case 2:
                    Shape = Shape.DIAMOND;
                    break;
                case 3:
                    Shape = Shape.TRIANGLE;
                    break;
                case 4:
                    Shape = Shape.TRAPEZOID;
                    break;
                case 5:
                    Shape = Shape.STAR;
                    break;
            }
        }

        override public int CompareTo(MemoryItem compareTo)
        {
            int same = 1;

            try
            {
                MemoryShape other = (MemoryShape)compareTo;
                if (Shape == other.Shape)
                    same = 0;
            }
            catch (Exception e)
            {
                throw new Exception(message: "Cannot convert MemoryItem to MemoryShape.");
            }

            return same;
        }


    }
}