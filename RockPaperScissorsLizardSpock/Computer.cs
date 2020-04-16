using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player // Child : Parent (inheritance)
    {
        // memmber variables (Has A)
        
        

        // constructor (Spawner)
        public Computer()
        {
           

        }

        // member methods (Can do)

        public override void ChooseGesture(List<string> gestureOptions)
        // computer chooses gesture here
        // generate random nubmer
        // use that number to select a random value from list of gestures
        {
            choice = gestureOptions[numGenerated];
        }
    }
}
