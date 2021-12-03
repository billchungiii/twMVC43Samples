// with expression

var r1 = new Rect(100, 100);
var r2 = r1 with { X = 9, Y = 9 };


public struct Rect
{
    public double X { get; set; }

    public double Y { get; set; }

    public Rect(double x, double y)
    {
        X = x;
        Y = y;
    }
}