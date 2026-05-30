using dot_net_course;

Point pointA = new Point(0, 0, "A");
Point pointB = new Point(4, 0, "B");
Point pointC = new Point(4, 3, "C");
Point pointD = new Point(0, 3, "D");

Figure figure = new Figure(pointA, pointB, pointC, pointD);

Console.WriteLine($"Polygon: {figure.name}");
Console.WriteLine($"Perimeter: {figure.perimeter}");
