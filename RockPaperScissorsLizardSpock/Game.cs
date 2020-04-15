using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Game // Base Class (Parent)
    {
        // member variables (Has A)
        public int pointsNeededToWin;
        public List<string> gestureOptions;
        public Player player1;
        public Player player2;

      // constructor (Spawner)
      public Game()
      {
            pointsNeededToWin = 3;
            player1 = new Human();
      }

        // member methods (Can do)
        // 1.Display rules (include how many rounds) (Good)
        // 2.Human v Human or Human v Computer (Good)
        // 3.Display gesture options
        // 4.Compare gestures (assign point to round winner)
        // 5.Display current score
        // 6.Check for gamer winner (best 2/3)
        // 7.If no winneer: repeat steps 3-6
        // 8.If winner: display final result
        // 9.Ask to play again
     
        public void RunGame()
        {
            DisplayRules();
            ChooseGameMode();

            player1.ChooseGesture();
            player2.ChooseGesture();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Here Are The Rules Of The Game");
            Console.WriteLine("Each Player Has 1 Turn Per Round");
            Console.WriteLine("First Player To Win 2 Rounds Wins The Game");
            Console.WriteLine("If Both Players Pick Same Gesture, Round Will Continue Until Someone Wins");
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Enter 1 for Human v Human or Enter 2 for Human v Computer:");

            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                player2 = new Human();
            }

            else if(userInput == "2")
            {
                player2 = new Computer(); 
            }

            else
            {
                Console.WriteLine("Try Again!")
            }

    }
}
