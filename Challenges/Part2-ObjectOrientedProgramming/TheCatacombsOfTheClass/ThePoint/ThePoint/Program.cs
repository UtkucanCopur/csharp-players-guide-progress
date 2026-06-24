Point newPoint = new Point(2,3);
Point anotherPoint = new Point(-4,0);

Console.WriteLine($"newpoint= ({newPoint.X},{newPoint.Y})");
Console.WriteLine($"newpoint= ({anotherPoint.X},{anotherPoint.Y})");




public class Point
{
    public int X;
    public int Y;

    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    
}

// My properties are not immutable here because this is a simple program
// so I didn't feel the need to use immutable properties.