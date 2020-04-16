using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
          // Parent Class
    abstract class Player
    {
        // member variables (Has A)
        public int score;
        public string chosenGesture;
        







        // constructor (Spawner)
        public Player(string Player)
        {
            name = Player;
        }

        





        

        // member methods (Can do)
        public virtual void ChooseGesture();
        public void choice()
        {
            Console.WriteLine("Players chooses gesture");
        }
         
    }
}
 
