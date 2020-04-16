using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player // Parent Class
    {
        // member variables (Has A)
        public string name;
        public int score;
        public string chosenGesture;

       





        // constructor (Spawner)
        public Player(string Player)
        {
            name = Player;
        }

        





        

        // member methods (Can do)
        public abstract void ChooseGesture();
        public void choice()
        {
            Console.WriteLine("");
        }
         
    }
}
 
