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
        public
        
        

        // constructor (Spawner)
        public Computer()
        {
            name = "Computer 1";  

        }

        // member methods (Can do)


        // computer chooses gesture here
        // generate random nubmer
        // use that number to select a random value from list of gestures
        public override void ChooseGesture(List<string> gestureOptions)

        // generate random gesture from the list
        {
            var random = new Random();
            var list = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]); 
        }
            
        
           
        
    }
}
