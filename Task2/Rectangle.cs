namespace dot_net_course;

public class Rectangle
{
    public double side1 { get; set; }
    public double side2 { get; set; }
    public double area { get; }
    public double perimeter { get; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.area = AreaCalculator();
        this.perimeter = PerimeterCalculator();
    }

    public double AreaCalculator()
    {
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }
}