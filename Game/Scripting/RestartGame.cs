// This class could start the game by hitting enter, then restart the game by hitting enter again.
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
        private bool start = false;
        public RestartGame() {}

        public void Execute(Cast cast, Script script) 
        {
            while (start == false) 
            {

            }
        }

    }
}