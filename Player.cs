using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public int playerScore;        

        public Player()
        {
            playerScore = 0;
        }

        public abstract void ChooseGesture();

    }


    
    
}
