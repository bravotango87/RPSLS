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
        public override void ChooseGesture(List<string> gestureOptions)
        {
            choice = gestureOptions[ ]; // generate random num between 0-5 & use random as index
        }
            
        
           
        
    }
}
