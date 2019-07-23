using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryGame.GameLogic
{
    public class Player
    {
        private string _username;

        private int _score;

        private int _lives;

        public string Username
        {
            get { return _username; }
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length > 15)
                    throw new Exception(message: "Invalid username");
                else
                    _username = value;
            }
        }

        public int Lives
        {
            get { return _lives; }
            set
            {
                if(value >= 0)
                    _lives = value;
                else
                    throw new Exception(message: "Lives cannot be negative");
            }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                if(value > 0)
                    _score = value;
                else
                    throw new Exception(message: "Score cannot be negative");
            }
        }

        public Player()
        {

        }

        public void Guess()
        {

        }

        public void LoseLife()
        {

        }

        public void GainScore(int score)
        {
            Score--;
        }
    }
}