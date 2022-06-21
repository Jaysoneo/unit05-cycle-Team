This game allows two players to see how long they can last 
without running into each other or themselves.
The controls for players one and two are:
up = w/i
down = s/k
left = a/j
right = d/l

Classes:
    Actor: 
    Sets up a generic character that returns values and 
    sets characteristics for the object.
    Cast:
    A class that sets a list of actors and allows the
    programmer to add, remove, and find parts of the cast.
    Color:
    Returns the colors red, gree, blue, and white.
    Point:
    Returns a point on the screen and calculates is 
    two points are on top of each other.
    Score:
    Inherits the actor class. Keeps track of how long the 
    game has run and returns that value as a method.
    Snake:
    Inherits the actor class. Sets up the head and body
    segments of the snake and uses polymorphism to 
    re-define the move next method.
    Director:
    The director runs the game loop by executing 
    input, update, and output actions
    Action:
    Action has a single method and is of type
    interface to allow for polymorphism.
    ContorlAcotrsAction:
    This allows the user to change direction of the 
    snakes by pressing the specified keys
    DrawActorsAction:
    This class draws the snakes, time, and messages
    HandleCollisionsAction:
    This class uses logic to determine if the snakes
    have collided with anything and makes sure that
    the correct action happens when this is the case
    MoveActorsAction:
    This class defines execute to use the movenext
    method for all of the classes
    script:
    This class handles different actions
    KeyboardService:
    This class allows the program to read key presses
    VideoService:
    This class handles anything to do with the screen,
    It draws the window, actors, and uses Raylib
     