using labyrinth;

public class Program
{
    /* Change this constant to contain your name.
     *
     * WARNING: Once you've set set this constant and started exploring your maze,
     * do NOT edit the value of YourName. Changing YourName will change which
     * maze you get back, which might invalidate all your hard work!
     */
    private static readonly String YOUR_NAME = "TODO: Replace this string with your name.";

    /* Change these constants to contain the paths out of your mazes. */
    private static readonly String PATH_OUT_OF_MAZE = "WNWSSSNNNEEESSWWSNEESW";
    private static readonly String PATH_OUT_OF_TWISTY_MAZE = "SSEENNEWE";

    public static void Main(String[] args)
    {
        MazeCell startLocation = MazeUtilities.mazeFor(YOUR_NAME);

        /* Set a breakpoint here to explore your maze! */

        if (MazeUtilities.isPathToFreedom(startLocation, PATH_OUT_OF_MAZE))
        {
            Console.WriteLine("Congratulations! You've found a way out of your labyrinth.");
        }
        else
        {
            Console.WriteLine("Sorry, but you're still stuck in your labyrinth.");
        }


        MazeCell twistyStartLocation = MazeUtilities.twistyMazeFor(YOUR_NAME);

        /* Set a breakpoint here to explore your twisty maze! */

        if (MazeUtilities.isPathToFreedom(twistyStartLocation, PATH_OUT_OF_TWISTY_MAZE))
        {
            Console.WriteLine("Congratulations! You've found a way out of your twisty labyrinth.");
        }
        else
        {
            Console.WriteLine("Sorry, but you're still stuck in your twisty labyrinth.");
        }
    }
}
