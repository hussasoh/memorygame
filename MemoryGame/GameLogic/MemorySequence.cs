using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public struct MemorySequence
    {
        public List<MemoryItem> Sequence;
        public float SpeedMultiplier;

        public MemorySequence(int length, MemoryItem memoryItem, float speed)
        {
            Sequence = new List<MemoryItem>();
            for(int i = 0; i < length; i++)
            {
                //temp logic
                Sequence.Add(memoryItem);

                // randomly generate and add memory items
            }
            SpeedMultiplier = speed;
        }
    }
}