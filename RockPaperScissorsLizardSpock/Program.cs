using System;

namespace RockPaperScissorsLizardSpock
{
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            gestureOptions gesture = new gestureOptions();
            game.AddGestureOptions(gesture);
            
            
        
        }
    }
}
