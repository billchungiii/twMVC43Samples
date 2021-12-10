using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    const string Score = "99";
    const string Name = "Bill";
    const string Description = $"{Name}'s Score is {Score}";


    static void Main(string[] args)
    {
        PrintText("全字串列印");

        PrintText($"字串插值列印, 時間 {DateTime.Now}, 這是結尾");
        PrintText($"沒有格式的字串");
        PrintText($"today is {DateTime.Now}");

        //CustomStringHandler handler = new CustomStringHandler(17, 1);
        //handler.AppendLiteral("字串插值列印, 時間 ");
        //handler.AppendFormatted(DateTime.Now);
        //handler.AppendLiteral(", 這是結尾");
        //PrintText(handler.ToString());

    }

    static void PrintText(string text)
    {
        Console.WriteLine(text);
    }

    static void PrintText(CustomStringHandler handler)
    {
        Console.WriteLine(handler);
    }
}

[InterpolatedStringHandler]
struct CustomStringHandler
{
    StringBuilder builder;
    public CustomStringHandler(int literalLength, int formatCount)
    {
        Console.WriteLine("\t進入建構式");
        builder = new StringBuilder(literalLength);
        Console.WriteLine($"\t固定字串長度 {literalLength} , 插值數量 {formatCount}");
    }

    public void AppendLiteral(string s)
    {
        Console.WriteLine($"\t要加入的固定字串 : {s}");
        builder.Append(s);
        Console.WriteLine("\t固定字串已加入");
    }

    public void AppendFormatted<T>(T t)
    {
        Console.WriteLine($"\t要加入的插值 : {t} , 它的型別是 : {typeof(T)}");
        builder.Append(t?.ToString());
        Console.WriteLine($"\t插值已加入");
    }

    public override string ToString()
    {
        return builder.ToString();
    }
}
