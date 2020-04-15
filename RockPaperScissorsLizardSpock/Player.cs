using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player // Child Class
    {
        // member variables (Has A)
        public int score;
        public string chooseGesture;
        

        // constructor (Spawner)
        public Player()
        {

        }

        // member methods (Can do)
        public abstract void ChooseGesture();
         
    }
}
 
