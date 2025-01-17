namespace pannella.analoguepocket;

public class Core
{
    public string name { get; set; }
    public bool allowPrerelease { get; set; }
    public Repo repo { get; set; }
    public Dependency assets { get; set; }
    public bool skip { get; set; }
    public string platform { get; set; }

    public override string ToString()
    {
        return platform + ": " + name;
    }
}