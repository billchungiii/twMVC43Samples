// CallerArgumebetExpressionAttribute sample
using System.Runtime.CompilerServices;

var a = 6;
var b = true;
Class1.CheckExpression(true);
Class1.CheckExpression(b);
Class1.CheckExpression(a > 5);
Class1.CheckDelegate((x, y) => x + y);
var data = new List<int> { 5, 6, 7, 8, 9 };
Class1.CheckSquence(new List<int> { 5, 6, 7, 8, 9 });

internal class Class1
{
    public static void CheckExpression(bool condition, [CallerArgumentExpression("condition")] string? message = null)
    {
        Console.WriteLine($"Condition: {message}");
    }

    public static void CheckDelegate(Func<int, int, int> func, [CallerArgumentExpression("func")] string? message = null)
    {
        Console.WriteLine($"Func is  : {message}");
    }

    public static void CheckSquence(IEnumerable<int> source, [CallerArgumentExpression("source")] string? message = null)
    {
        Console.WriteLine($"Squence is  : {message}");
    }
}