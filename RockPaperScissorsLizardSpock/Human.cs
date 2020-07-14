using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    // Child : Parent (inheritance)
    class Human : Player
    {
        // member variables (Has A)

        // constructor (Spawner)
        public Human()
        {

        }

        public override void ChooseGesture()
        {
            PickedGesture();
        }

        public override void SetName()
        {
            Console.WriteLine("Please enter in your name.");
            name = Console.ReadLine();
        }



        // member methods (Can do)
        // human chooses gesture here

        public void PickedGesture()
        {
            Console.WriteLine("Please choose a gesture.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Rock":
                    Console.WriteLine("Player chooses Rock");
                    choice = "Rock";
                    break;
                case "Paper":
                    Console.WriteLine("Player chooses" + userInput);
                    choice = "Paper";
                    break;
                case "Scissors":
                    Console.WriteLine("Player chooses" + userInput);
                    break;
                case "Lizard":
                    Console.WriteLine("Player chooses" + userInput);
                    break;
                case "Spock":
                    Console.WriteLine("Player chooses" + userInput);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    ChooseGesture();
                    break;
            }


        }
    }
}
