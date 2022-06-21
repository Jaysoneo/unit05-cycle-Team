using unit05_cycle_Team.Game.Casting;
using unit05_cycle_Team.Game.Directing;
using unit05_cycle_Team.Game.Scripting;
using unit05_cycle_Team.Game.Services;

//Commit this
namespace unit05_cycle_Team
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();
            cast.AddActor("snake", new Snake(1));
            cast.AddActor("snake", new Snake(2));
            cast.AddActor("time", new Time(cast));

            // create the services
            KeyboardService keyboardService= new KeyboardService();
            VideoService videoService = new VideoService(false);
            RestartGame startGame = new RestartGame(keyboardService);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("input", new RestartGame(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
            
        }
    }
}
//Test comment
//haha yes