// infer delegate type for lambda

using System.Linq.Expressions;

var parse1 = (string s) => int.Parse(s);
object parse2 = (string s) => int.Parse(s);
Delegate parse3 = (string s) => int.Parse(s);

// infer delegate type for method group
var read = Console.Read;

// lambda expression
// LambdaExpression<Func<string,int>>
LambdaExpression expression1 = (string s) => int.Parse(s);
Expression expression2 = (string s) => int.Parse(s);

// declared return type
var choose = object (bool b) => b ? 1 : "two";


// apply attribute
var parse =[Some(1)] (string s) => int.Parse(s);



internal class SomeAttribute : Attribute
{
    private int v;

    public SomeAttribute(int v)
    {
        this.v = v;
    }
}