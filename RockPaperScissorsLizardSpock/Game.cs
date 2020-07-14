using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        // member variables (Has A)
        public int pointsToWin;
        public Player player1;
        public Player player2;

        // constructor (Spawner)
        public Game()
        {
            pointsToWin = 3;
            player1 = new Human();





        }

       

        // member methods (Can do)
        // 1.Display rules (include how many rounds) (Good)
        // 2.Human v Human or Human v Computer (Good)
        // 3.Display gesture options (Good)
        // 4.Compare gestures (assign point to round winner)
        // 5.Display current score
        // 6.Check for gamer winner (best 2/3)
        // 7.If no winneer: repeat steps 3-6
        // 8.If winner: display final result
        // 9.Ask to play again

        public void DisplayRules()
        {
            Console.WriteLine("Here Are The Rules Of The Game");
            Console.WriteLine("Each Player Has 1 Turn Per Round");
            Console.WriteLine("Best of 3 Rounds Wins The Game");
            Console.WriteLine("If Both Players Pick Same Gesture, Round Will Continue Until Someone Wins");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }


        public void AddGestureOptions(List<string> gestureOptions)
        {


        }

        public void SetName()
        {
            Console.WriteLine("Please enter in your name.");
            Console.ReadLine();
        }
        public void RunGame()
        {
            DisplayRules();
            ChooseGameMode();
            while (player1.score < pointsToWin && player2.score < pointsToWin)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
                DisplayRoundWinner();

            }
            DisplayGameWinner();

            player1.ChooseGesture();
            player2.ChooseGesture();
        }

       
        public void ChooseGameMode()
        {
            Console.WriteLine("Enter 1 for Human v Computer or Enter 2 for Human v Human");

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                player2 = new Computer();
            }

            else if (userInput == "2")
            {
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("Try Selection Again!");
            }


        }

        public void CompareGestures()
        {

            string player2Input;
            string player1Input;
            player2Input = player2.choice;
            player1Input = player1.choice;
            player1.score = 0;
            player2.score = 0;


            switch (player2.choice)
            {
                case "Rock":
                    player2Input = "Rock";
                    Console.WriteLine(player2.name + " chose Rock!");
                    if (player1Input == "Rock")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                        player1.score++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Paper covers Rock");
                        player1.score++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Rock crushes Sissors");
                        player2.score++;
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                        player2.score++;
                    }
                    break;
                case "Paper":
                    player2Input = "Paper";
                    Console.WriteLine(player2.name + " chose Paper!");
                    if (player1Input == "Paper")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Paper disproves Spock");
                        player2.score++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Paper covers Rock");
                        player2.score++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                        player1.score++;
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        player1.score++;
                    }
                    break;
                case "Sissors":
                    player2Input = "Sissors";
                    Console.WriteLine(player2.name + " chose Sissors!");
                    if (player1Input == "Sissors")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Spock smashes Scissors");
                        player1.score++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Rock crushes Scissors");
                        player1.score++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                        player2.score++;
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                        player2.score++;
                    }
                    break;
                case "Lizard":
                    player2Input = "Lizard";
                    Console.WriteLine(player2.name + " chose Lizard!");
                    if (player1Input == "Lizard")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                        player2.score++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                        player1.score++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        player2.score++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                        player1.score++;
                    }
                    break;
                case "Spock":
                    player2Input = "Spock";
                    Console.WriteLine(player2.name + " chose Spock!");
                    if (player1Input == "Spock")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                        player1.score++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                        player2.score++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Paper disproves Spock");
                        player1.score++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Spock smashes Scissors");
                        player2.score++;
                    }
                    break;
            }



        }

        public void DisplayRoundWinner()
        {
            if (player1.score > player2.score)
            {
                player1.score++;
                Console.WriteLine(player1.name + " Won this round!");
                Console.WriteLine("");
                Console.WriteLine(player1.name + ", your current score is " + player1.score);
                Console.WriteLine(player2.name + ", your current score is " + player2.score);
                Console.WriteLine("");
            }
            else if (player2.score > player1.score)
            {
                player2.score++;
                Console.WriteLine(player2.name + " Won this round!");
                Console.WriteLine("");
                Console.WriteLine(player1.name + ", your current score is " + player1.score);
                Console.WriteLine(player2.name + ", your current score is " + player2.score);
                Console.WriteLine("");
            }
            else if (player2.score == player1.score)
            {
                Console.WriteLine("");
                Console.WriteLine(player1.name + ", your current score is " + player1.score);
                Console.WriteLine(player2.name + ", your current score is " + player2.score);
                Console.WriteLine("");
            }
        }

        public void DisplayGameWinner()
        {
            

            if (player1.score == pointsToWin)
            {
                Console.WriteLine(player1.name + " has won the game!");
            }
            else if (player2.score == pointsToWin)
            {
                Console.WriteLine(player2.name + " has won the game!");
            }
        }


    }

}
