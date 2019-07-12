using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class ScoreList
    {
        // how will player names be attached to scores?
        // will need a 2D list?
        private List<int> _highScores;
        private List<int> _highPlayerScores;

        public ScoreList(List<int> highScores, List<int> highPlayerScores)
        {
            _highScores = highScores;
            _highPlayerScores = highPlayerScores;

            SortScores();
        }

        public void SortScores()
        {

        }

        public void InsertPlayerScore(int score)
        {
            // insert new score into both lists
            _highScores.Add(score);
            _highPlayerScores.Add(score);
            SortScores();
        }

        public void GetTopNScores(int n, out List<int> highScores, out List<int> highPlayerScores)
        {
            if (n > 0 && n < _highScores.Count && n < _highPlayerScores.Count)
            {
                highScores = new List<int>();
                highPlayerScores = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    highScores.Add(_highScores[i]);
                    highPlayerScores.Add(_highPlayerScores[i]);
                }
                
            }
            else
            {
                throw new Exception(message: "Attempted to retrieve too many scores.");
            }
        }
    }
}