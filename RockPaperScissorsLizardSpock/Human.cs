using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player //Class (Parent : Child) (inheritance)
    {
        // member variables (Has A)
        public int score;
        public string chooseGesture;

        // constructor (Spawner)
        public Human()
        {

        }

        // member methods (Can do)
        public override void ChooseGesture()
        {
            // Human chooses gesture
        }


    }
}
