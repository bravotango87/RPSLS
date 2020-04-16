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

          
        public override void SetName()
        {
            Console.WriteLine("Please enter in your name.");
            name = Console.ReadLine();
        }



        // member methods (Can do)
        // human chooses gesture here

        public virtual void ChooseGesture(List<string> gestureOptions)
        {
            Console.WriteLine("Please choose a gesture.");
            string userInput = Console.ReadLine();

            switch (gestureOptions)
            {
                case "Rock":
                    Console.WriteLine("Player chooses" + userInput);
                    break;
                case "Paper":
                    Console.WriteLine("Player chooses" + userInput);
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
            }


        }
}
