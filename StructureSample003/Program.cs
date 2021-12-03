
Console.WriteLine("Hello, World!");

public readonly record struct Point3D (double x, double y, double z);

public readonly record struct Point3DX
{
    public double X { get; init; }
    public double Y { get; init; }

    public double Z { get; init; }
}
public record struct Point2D (double x,  double y);