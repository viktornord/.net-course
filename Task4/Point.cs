namespace dot_net_course;

public class Point
{
    public int X { get; }
    public int Y { get; }
    public string Name { get; }

    public Point(int x, int y, string name)
    {
        this.X = x;
        this.Y = y;
        this.Name = name;
    }
}
