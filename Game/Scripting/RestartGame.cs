// This class could start the game by hitting enter, then restart the game by hitting enter again.
using System;
using System.Collections.Generic;
using unit05_cycle_Team.Game.Casting;
using unit05_cycle_Team.Game.Services;


namespace unit05_cycle_Team.Game.Scripting
{
    
    /// <summary>
    /// <para>
    /// The responsibility of RestartGame is to restart  
    /// the game when the user presses the enter key.
    /// </para>
    /// </summary>

    public class RestartGame : Action
    {
        private KeyboardService keyboardService;
        public bool start = false;
        public RestartGame(KeyboardService keyboardService) 
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script) 
        {
            List<Actor> all_snakes = cast.GetActors("snake");
            Actor time = cast.GetFirstActor("time");

            if (keyboardService.IsKeyDown("\n"))
            {
                Console.WriteLine("Enter key pressed");
                foreach (Snake snake in all_snakes)
                {
                    cast.RemoveActor("snake", snake);
                }
                cast.RemoveActor("time", time);
            }
        }

    }
}