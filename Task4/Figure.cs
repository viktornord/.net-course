namespace dot_net_course;

public class Figure
{
    Point[] points;
    public string name { get; }
    public double perimeter { get; private set; }

    public Figure(Point point1, Point point2, Point point3)
    {
        points = [point1, point2, point3];
        name = "Triangle";
        PerimeterCalculator();
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = [point1, point2, point3, point4];
        name = "Quadrilateral";
        PerimeterCalculator();
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = [point1, point2, point3, point4, point5];
        name = "Pentagon";
        PerimeterCalculator();
    }

    public double LengthSide(Point A, Point B)
    {
        int dx = B.X - A.X;
        int dy = B.Y - A.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void PerimeterCalculator()
    {
        double total = 0;

        for (int i = 0; i < points.Length; i++)
        {
            Point current = points[i];
            Point next = points[(i + 1) % points.Length];
            total += LengthSide(current, next);
        }

        perimeter = total;
    }
}
