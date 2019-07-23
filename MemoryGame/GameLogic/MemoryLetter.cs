using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class MemoryLetter: MemoryItem
    {
        private char _letter;

        public char Letter
        {
            get { return _letter; }
            set
            {
                if (Char.IsUpper(value))
                    _letter = value;
                else
                    throw new Exception("A MemoryLetter can only be an uppercase letter from A-Z.");
            }
        }


        /// <summary>
        /// Generates a random uppercase letter
        /// </summary>
        override public void GenerateItem()
        {
            Random rand = new Random();
            Letter = (char)rand.Next('A', 'Z');
        }

        /// <summary>
        /// Checks if this letter is the same as another
        /// </summary>
        /// <param name="compareTo"></param>
        /// <returns></returns>
        override public int CompareTo(MemoryItem compareTo)
        {
            int same = 1;

            try
            {
                MemoryLetter other = (MemoryLetter)compareTo;
                if (Letter.Equals(other.Letter))
                    same = 0;      
            }
            catch (Exception e)
            {
                throw new Exception(message: "Cannot convert MemoryItem to MemoryLetter.");
            }

            return same;
        }

    }
}