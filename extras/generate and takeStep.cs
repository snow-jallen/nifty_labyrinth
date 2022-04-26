
    List<string> simpleDiagram = new();
    public string YourName{get;set;} = "TODO: Put your name here";
    string simpleSolution = "";
    bool simpleSolved = false;
    string twistySolution = "";

    void generate()
    {
        simpleDiagram = takeStep(MazeUtilities.mazeFor(YourName));
        twistyDiagram = takeStep(MazeUtilities.twistyMazeFor(YourName));
    }

    void solveSimple()
    {
        simpleSolved = MazeUtilities.isPathToFreedom(MazeUtilities.mazeFor(YourName), simpleSolution);
    }

    void solveTwisty()
    {
        twistySolved = MazeUtilities.isPathToFreedom(MazeUtilities.twistyMazeFor(YourName), twistySolution);
    }

    List<string> takeStep(MazeCell cell)
    {
        var visited = new List<NodeLink>();
        List<string> diagram = new();
        diagram.Add("graph TD");
        diagram.Add("start");

        takeStep(cell, visited, diagram);

        return diagram;
    }

    List<string> takeStep(MazeCell cell, List<NodeLink> visited, List<string> diagram)
    {
        if (cell.East != null)
        {
            var link = new NodeLink(cell, cell.East, "East");
            if (visited.Contains(link) is false)
            {
                logger.LogInformation($"Moving East from {cell.Id} to {cell.East.Id}");
                visited.Add(link);
                diagram.Add(link.ToString());
                takeStep(cell.East, visited, diagram);
            }
        }
        if (cell.South != null)
        {
            var link = new NodeLink(cell, cell.South, "South");
            if (visited.Contains(link) is false)
            {
                logger.LogInformation($"Moving South from {cell.Id} to {cell.South.Id}");
                visited.Add(link);
                diagram.Add(link.ToString());
                takeStep(cell.South, visited, diagram);
            }
        }
        if (cell.West != null)
        {
            var link = new NodeLink(cell, cell.West, "West");
            if (visited.Contains(link) is false)
            {
                logger.LogInformation($"Moving West from {cell.Id} to {cell.West.Id}");
                visited.Add(link);
                diagram.Add(link.ToString());
                takeStep(cell.West, visited, diagram);
            }
        }
        if (cell.North != null)
        {
            var link = new NodeLink(cell, cell.North, "North");
            if (visited.Contains(link) is false)
            {
                logger.LogInformation($"Moving North from {cell.Id} to {cell.North.Id}");
                visited.Add(link);
                diagram.Add(link.ToString());
                takeStep(cell.North, visited, diagram);
            }
        }
        return diagram;
    }
