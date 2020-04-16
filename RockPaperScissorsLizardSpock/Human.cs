using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    // Child : Parent (inheritance)
    class Human : Player
    {
        // member variables (Has A)
        public string name;
        public bool isPlayersTurn;






        // constructor (Spawner)
        public Human()
        {
            name = "Player 1";
            isPlayersTurn = true;

        }






        // member methods (Can do)
        // human chooses gesture here
        
        public override void ChooseGesture(List<string> gestureOptions)
        {
            Console.WriteLine("Player Chooses:"
        }


    }
}
