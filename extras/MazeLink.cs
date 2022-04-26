public class NodeLink
{
    public NodeLink(MazeCell from, MazeCell to, string label)
    {
        From = from;
        To = to;
        Label = label;
    }
    public MazeCell From { get; set; }
    public MazeCell To { get; set; }
    public String Label { get; set; }

    public override int GetHashCode()
    {
        return HashCode.Combine(From, To);
    }

    public override bool Equals(object obj)
    {
        return obj is NodeLink link && link.From.Equals(From) && link.To.Equals(To);
    }

    public override string ToString()
    {
        var FromSymbol = From.WhatsHere switch
        {
            Item.Potion => " Potion",
            Item.Spellbook => " Spellbook",
            Item.Wand => " Wand",
            _ => ""
        };
        var ToSymbol = To.WhatsHere switch
        {
            Item.Potion => " Potion",
            Item.Spellbook => " Spellbook",
            Item.Wand => " Wand",
            _ => ""
        };
        return $"{From.Id}[{From.Id} {FromSymbol}] -- {Label} --> {To.Id}[{To.Id} {ToSymbol}]\n";
    }

}