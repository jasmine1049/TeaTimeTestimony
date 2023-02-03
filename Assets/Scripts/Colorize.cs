public class Colorize
{

    public static Colorize RED = new Colorize("red");
    public static Colorize YELLOW = new Colorize("yellow");
    public static Colorize GREEN = new Colorize("green");
    public static Colorize BLUE = new Colorize("blue");
    
    private readonly string prefix;
    private const string suffix = "</color>";
    
    private Colorize(string color)
    {
        this.prefix = "<color="+color+">";
    }

    public static string operator %(string text, Colorize color)
    {
        return color.prefix + text + suffix;
    }
    
}