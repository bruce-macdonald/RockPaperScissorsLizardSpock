using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {   //random variable for roll
        
        Random r = new Random();
        

        public override void ChooseGesture()
        {
            // Generate a random number based on the lenght of the list
            // User the random number you generated as an index number to grab a random value out of the list of gestures
            int randomNumber = r.Next(5);
            chosenGesture = gestures[randomNumber];
            Console.WriteLine($"Computer has chosen{chosenGesture}");
        }

    }
}
