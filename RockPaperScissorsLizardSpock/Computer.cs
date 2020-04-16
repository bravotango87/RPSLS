using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
          // Child : Parent (inheritance)
    class Computer : Player
    {
        // memmber variables (Has A)
        public string name;
        public bool isComputerTurn;
        
        

        // constructor (Spawner)
        public Computer()
        {
            name = "Computer 1";  

        }

        // member methods (Can do)


        // computer chooses gesture here
        // generate random nubmer
        // use that number to select a random value from list of gestures
        public virtual void ChooseGesture(List<string> gestureOptions)
        {
            Console.Write("Please choose a gesture");
            string gesture = Console.ReadLine();

            switch (gestureOptions)
            {
                case "Rock":
                    Console.WriteLine("Computer chooses" + gestureOptions);
                    break;
                case "Paper":
                    Console.WriteLine("Computer chooses" + gestureOptions);
                    break;
                case "Scissors":
                    Console.WriteLine("Computer chooses" + gestureOptions);
                    break;
                case "Lizard":
                    Console.WriteLine("Computer chooses" + gestureOptions);
                    break;
                case "Spock":
                    Console.WriteLine("Computer chooses" + gestureOptions);
                    break;
            }


            }
        
           
        
    }
}
