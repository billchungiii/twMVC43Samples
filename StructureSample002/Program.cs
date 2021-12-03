// file / property initializer
public class Program
{
    static void Main(string[] args)
    {
        var s1 = new MyStructure();
        Console.WriteLine(s1);
        var s2 = default(MyStructure);
        Console.WriteLine(s2);

    }


}

struct MyStructure
{
    public double Value { get; set; }

    // C# 10
    public string Name { get; set; } = "Bill";

    
    public MyStructure()
    {
        Value = double.NaN;
    }

    public MyStructure(int value, string name)
    {
        Value = value;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Value},{ (Name == null ? "this is null" : Name)}";
    }

}

