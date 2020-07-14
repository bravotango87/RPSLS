using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
          // Parent Class
    abstract public class Player
    {
        // member variables (Has A)


        public int score;
        public string choice;
        public List<string> gestureOptions;








        // constructor (Spawner)

        public Player()
        {
            gestureOptions = new List<string>();
            GetGestureOptions();
        }



        // member methods (Can do)

        public void GetGestureOptions()
        {
            

            gestureOptions.Add("Rock");
            gestureOptions.Add("Paper");
            gestureOptions.Add("Scissors");
            gestureOptions.Add("Lizard");
            gestureOptions.Add("Spock");
           
        }
        public void DisplayGestureOptions()
        {
            foreach (string gesture in gestureOptions)
            {
                Console.WriteLine(gesture);
            }
        }
        public abstract void ChooseGesture();








        


         
    }
}
 
