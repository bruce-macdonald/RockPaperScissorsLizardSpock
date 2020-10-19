using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;


        public void Introduction()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("The rules go as follows:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Lizard poisons Spock");
        }

        public Game()
        {
            Introduction();
            DecidePlayerTypes();
            CompareGestures();
            DeclareGameWinner();
        }       

        public void DecidePlayerTypes()
        {
            Console.WriteLine("What Type of Game would you like to play?");
            Console.WriteLine("Press 1 to play against a computer");
            Console.WriteLine("Press 2 to play another human");
            string userInput = Console.ReadLine();
            switch (userInput)
            {   case "1": 
                    playerOne = new HumanPlayer();
                    playerTwo = new ComputerPlayer();
                    break;
                case "2":
                    playerOne = new HumanPlayer();
                    playerTwo = new HumanPlayer();
                    break;
                default: DecidePlayerTypes();
                    break;
            }
        }

        public void CompareGestures()
        {
            while (playerOne.playerScore < 2 || playerTwo.playerScore < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!\n Choose again!");               
            }
            else if (playerOne.chosenGesture == playerOne.gestures[0]) //playerOne gestures rock
            {
                
                if (playerTwo.chosenGesture == playerTwo.gestures[2] || playerTwo.chosenGesture == playerTwo.gestures[3])
                {
                    Console.WriteLine($"{playerOne.chosenGesture} beats {playerTwo.chosenGesture}!");
                    Console.WriteLine($"Player one score: {playerOne.playerScore}");
                    Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                        playerOne.playerScore++;
                }
                else if (playerTwo.chosenGesture == playerTwo.gestures[1] || playerTwo.chosenGesture == playerTwo.gestures[4])
                {
                        Console.WriteLine($"{playerTwo.chosenGesture} beats {playerOne.chosenGesture}!");
                        Console.WriteLine($"Player one score: {playerOne.playerScore}");
                        Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                        playerTwo.playerScore++;
                }
            }
            else if (playerOne.chosenGesture == playerOne.gestures[1]) //player one gestures paper
            {
                if (playerTwo.chosenGesture == playerTwo.gestures[0] || playerTwo.chosenGesture == playerTwo.gestures[4])
                {
                        Console.WriteLine($"{playerOne.chosenGesture} beats {playerTwo.chosenGesture}!");
                        Console.WriteLine($"Player one score: {playerOne.playerScore}");
                        Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                        playerOne.playerScore++;
                }
                else if (playerTwo.chosenGesture == playerTwo.gestures[2] || playerTwo.chosenGesture == playerTwo.gestures[3])
                {
                        Console.WriteLine($"{playerTwo.chosenGesture} beats {playerOne.chosenGesture}!");
                        Console.WriteLine($"Player one score: {playerOne.playerScore}");
                        Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                        playerTwo.playerScore++;
                }
            }
            else if (playerOne.chosenGesture == playerOne.gestures[2]) //playerOne gestures scissors
            {
                if (playerTwo.chosenGesture == playerTwo.gestures[1] || playerTwo.chosenGesture == playerTwo.gestures[3])
                {
                        Console.WriteLine($"{playerOne.chosenGesture} beats {playerTwo.chosenGesture}!");
                        Console.WriteLine($"Player one score: {playerOne.playerScore}");
                        Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                        playerOne.playerScore++;
                }
                else if (playerTwo.chosenGesture == playerTwo.gestures[0] || playerTwo.chosenGesture == playerTwo.gestures[4])
                {
                        Console.WriteLine($"{playerTwo.chosenGesture} beats {playerOne.chosenGesture}!");
                        Console.WriteLine($"Player one score: {playerOne.playerScore}");
                        Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                        playerTwo.playerScore++;
                }



            else if (playerOne.chosenGesture == playerOne.gestures[3]) //playerOne gestures lizard
                {
                    
                    if (playerTwo.chosenGesture == playerTwo.gestures[1] || playerTwo.chosenGesture == playerTwo.gestures[4])
                    {
                            Console.WriteLine($"{playerOne.chosenGesture} beats {playerTwo.chosenGesture}!");
                            Console.WriteLine($"Player one score: {playerOne.playerScore}");
                            Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                            playerOne.playerScore++;
                    }
                    else if (playerTwo.chosenGesture == playerTwo.gestures[0] || playerTwo.chosenGesture == playerTwo.gestures[2])
                    {
                            Console.WriteLine($"{playerTwo.chosenGesture} beats {playerOne.chosenGesture}!");
                            Console.WriteLine($"Player one score: {playerOne.playerScore}");
                            Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                            playerTwo.playerScore++;
                    }
                }

                else if (playerOne.chosenGesture == playerOne.gestures[4]) //playerOne gestures spock
                {

                    if (playerTwo.chosenGesture == playerTwo.gestures[0] || playerTwo.chosenGesture == playerTwo.gestures[2])
                    {
                            Console.WriteLine($"{playerOne.chosenGesture} beats {playerTwo.chosenGesture}!");
                            Console.WriteLine($"Player one score: {playerOne.playerScore}");
                            Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                            playerOne.playerScore++;
                    }
                    else if (playerTwo.chosenGesture == playerTwo.gestures[1] || playerTwo.chosenGesture == playerTwo.gestures[3])
                    {
                            Console.WriteLine($"{playerTwo.chosenGesture} beats {playerOne.chosenGesture}!");
                            Console.WriteLine($"Player one score: {playerOne.playerScore}");
                            Console.WriteLine($"Player two score: {playerTwo.playerScore}");
                            playerTwo.playerScore++;
                    }
                }
            }
            }

        }
        public void DeclareGameWinner()
        {
            if (playerOne.playerScore == 2 && playerTwo.playerScore <= 2)
            {
                Console.WriteLine("The Winner is Player One!");
            }

            if (playerTwo.playerScore == 2 && playerOne.playerScore <= 2)
            {
                Console.WriteLine("The Winner is Player Two!");
            }
        }




    }
}
