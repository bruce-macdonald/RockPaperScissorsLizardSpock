using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class HumanPlayer : Player
    { 

        public HumanPlayer()
        {

        }
     
       public override void ChooseGesture()
        {
            Console.WriteLine($"You've chosen________");
        }
    }


    
}
