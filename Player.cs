using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public int playerScore;
        public List<string> gestures;
        public string chosenGesture;


        public Player()
        {
            gestures = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spock" };
            playerScore = 0;
        }

        public abstract void ChooseGesture();


    }


    
    
}
