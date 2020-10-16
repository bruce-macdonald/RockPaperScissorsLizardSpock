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
            // Display the options
            DisplayGestures();
            // Get the users input and confrim that it is a valid choice (Make sure you dont accept somthing that is not a gesture)
            int response = Convert.ToInt32(Console.ReadLine());
            //chosenGesture = gestures[response]; same as swiutch, but won't reprompt

            switch (response)
            {
                case 0: chosenGesture = gestures[0];
                    break;
                case 1: chosenGesture = gestures[1];
                    break;
                case 2: chosenGesture = gestures[2];
                    break;
                case 3: chosenGesture = gestures[3];
                    break;
                case 4: chosenGesture = gestures[4];
                    break;
                default: DisplayGestures();
                    break;
                    
                    
            }
            //if (chosenGesture >=0 && chosenGesture <= 4);
            //{                
            //    Console.WriteLine($"You've chosen{chosenGesture}");
            //}
            //else; 
            //{
            //    Console.WriteLine("Please enter a number between 0 and 4\n");
            //    DisplayGestures();
            //}

        }

        public void DisplayGestures()
        {
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i}): {gestures[i]}\n");
            }
        }

        
    }


    
}
