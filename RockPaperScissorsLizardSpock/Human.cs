using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player // Child : Parent (inheritance)
    {
        // member variables (Has A)
        public string name;
        public Human human;
       
            
        // constructor (Spawner)
        public Human()
        {
         
        }

        // member methods (Can do)
        public override void ChooseGesture()
        // human chooses gesture here
        {
            Console.WriteLine("Select Choice");
        }


    }
}
