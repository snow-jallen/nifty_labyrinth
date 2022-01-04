namespace labyrinth;

/**
 * Type representing a cell in a maze.
 */
public class MazeCell
{
    public String whatsHere = ""; // One of "", "Potion", "Spellbook", and "Wand"

    public MazeCell north = null;
    public MazeCell south = null;
    public MazeCell east = null;
    public MazeCell west = null;
    public override string ToString()
    {
        return this.GetHashCode().ToString();
    }
}
