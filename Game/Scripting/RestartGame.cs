// This class could start the game by hitting enter, then Exit the game by hitting enter again.
using System;
using System.Collections.Generic;
using unit05_cycle_Team.Game.Directing;
using unit05_cycle_Team.Game.Casting;
using unit05_cycle_Team.Game.Services;


namespace unit05_cycle_Team.Game.Scripting
{
    
    /// <summary>
    /// <para>
    /// The responsibility of ExitGame is to Exit  
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
                var args = new string[] {"arg1","arg2","arg3"};
                Console.WriteLine("Enter key pressed");
                videoService.CloseWindow();
            }
        }
    }
}