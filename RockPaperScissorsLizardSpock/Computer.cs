using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
          // Child : Parent (inheritance)
    class Computer : Player
    {
        // memmber variables (Has A)
        
        

        // constructor (Spawner)
        public Computer()
        {  

        }

        // member methods (Can do)
       

        // computer chooses gesture here
        // generate random nubmer
        // use that number to select a random value from list of gestures
        public override void ChooseGesture()

        // generate random gesture from the list
        {
            Random rnd = new Random();
            int i = RandomNumber(rnd);

            choice = gestureOptions[i];

            if (choice == "1")
            {
                choice = "Rock";
            }
            if (choice == "2")
            {
                choice = "Paper";
            }
            if (choice == "3")
            {
                choice = "Sissors";
            }
            if (choice == "4")
            {
                choice = "Lizard";
            }
            if (choice == "5")
            {
                choice = "Spock";
            }

        }



        public override void SetName()
        {
            name = "Computer";
        }

        public int RandomNumber(Random random)
        {
            int numberGenerated = random.Next(1, 5);
            return numberGenerated;
        }
    }
}
