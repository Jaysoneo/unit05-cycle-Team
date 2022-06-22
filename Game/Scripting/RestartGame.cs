// This class could start the game by hitting enter, then restart the game by hitting enter again.
using System;
using System.Collections.Generic;
using unit05_cycle_Team.Game.Directing;
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

    public class ExitGame : Action
    {
        private KeyboardService keyboardService;
        private VideoService videoService;
        public bool start = false;
        public ExitGame(KeyboardService keyboardService, VideoService videoService) 
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script) 
        {
            if (keyboardService.IsKeyDown("\n"))
            {
                Console.WriteLine("Enter key pressed");
<<<<<<< HEAD
                //foreach (Snake snake in all_snakes)
                //{
                //    cast.RemoveActor("snake", snake);
                //}
                //cast.RemoveActor("time", time);
=======
                videoService.CloseWindow();
>>>>>>> 6d470b7c26b6f8e4a6ea5da00b29704fbf7456d6
            }
        }
    }
}