using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class MemoryNumber: MemoryItem
    {
        private int _number;

        /// <summary>
        /// Ensures _number is a digit from 0-9
        /// </summary>
        public int Number
        {
            get { return _number; }
            set
            {
                if (value >= 0 && value <= 9)
                    _number = value;
                else
                    throw new Exception(message: "MemoryNumber must be a digit from 0-9.");
            }
        }

        /// <summary>
        /// Generates a random number between 0 and 9
        /// </summary>
        override public void GenerateItem()
        {
            Random rand = new Random();
            Number = rand.Next(10);
        }

        /// <summary>
        /// Compares two memory numbers
        /// </summary>
        /// <param name="compareTo"></param>
        /// <returns></returns>
        override public int CompareTo(MemoryItem compareTo)
        {
            int same = 1;

            try
            {
                MemoryNumber other = (MemoryNumber)compareTo;
                if (Number == other.Number)
                    same = 0;
            }
            catch (Exception e)
            {
                throw new Exception(message: "Cannot convert MemoryItem to MemoryNumber.");
            }

            return same;
        }
    }
}