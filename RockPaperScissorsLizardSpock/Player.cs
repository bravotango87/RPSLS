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
        public string choice;
        public List<string> gestureOptions;
        public string name;





         

        // constructor (Spawner)
        public Player()
        {
            gestureOptions = new List<string>();

            gestureOptions.Add("Rock");
            gestureOptions.Add("Paper");
            gestureOptions.Add("Scissors");
            gestureOptions.Add("Lizard");
            gestureOptions.Add("Spock");
            SetName();
        }



         



        public abstract void SetName();

        // member methods (Can do)
        public abstract void ChooseGesture();

         
    }
}
 
