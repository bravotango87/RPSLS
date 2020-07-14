using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    // Child : Parent (inheritance)
    public class Human : Player
    {
        // member variables (Has A)


        // constructor (Spawner)
        public Human()
        {
            score = 0;
        }


        



        // member methods (Can do)
        // human chooses gesture here

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a gesture to perform:");
            DisplayGestureOptions();
            bool validChoice = false;
            

            while (!validChoice)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {



                    case "Rock":
                        Console.WriteLine("Player chooses Rock");
                        choice = "Rock";
                        validChoice = true;
                        break;
                    case "Paper":
                        Console.WriteLine("Player chooses" + userInput);
                        choice = "Paper";
                        validChoice = true;
                        break;
                    case "Scissors":
                        Console.WriteLine("Player chooses" + userInput);
                        choice = "Scissors";
                        validChoice = true;
                        break;
                    case "Lizard":
                        Console.WriteLine("Player chooses" + userInput);
                        choice = "Lizard";
                        validChoice = true;
                        break;
                    case "Spock":
                        Console.WriteLine("Player chooses" + userInput);
                        choice = "Spock";
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        validChoice = false;

                        break;
                }
            }


        }
    }
}
