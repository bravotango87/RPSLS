using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
          // Child : Parent (inheritance)
    class Computer : Player
    {
        // memmber variables (Has A)
        
        

        // constructor (Spawner)
        public Computer()
        {  

        }

        // member methods (Can do)
        public override void SetName()
        {
            name = "Computer";
        }

        // computer chooses gesture here
        // generate random nubmer
        // use that number to select a random value from list of gestures
        public override void ChooseGesture()

        // generate random gesture from the list
        {
            var random = new Random();
            //list = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            int index = random.Next(gestureOptions.Count);
            choice = gestureOptions[index];
            Console.WriteLine("Computer has choose " + choice); 
        }
            
        
           
        
    }
}
