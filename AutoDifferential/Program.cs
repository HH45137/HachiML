using System;
using HachiDeep;
using HachiDeep.Operator;
using NumSharp;

namespace AutoDifferential;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--------== Hello Hachi-Deep Machine Learning Framework! ==--------\n");

        var data = np.array([[1.2, 2.5, 6.2], [1, 6, 9]]);
        var x0 = new Variable(data);
        Console.WriteLine($"value = {x0.Data}");
        Console.WriteLine($"dim = {x0.Data.ndim}");

        Console.WriteLine();

        var x1 = new Variable(10.0);
        var f = new Square().Call;
        var y1 = f(x1);
        Console.WriteLine(y1.Data.GetType());
        Console.WriteLine(y1);

        Console.WriteLine();

        var A = Operators.Square;
        var B = Operators.Exp;
        var C = Operators.Square;
        var x2 = new Variable(.5);
        var a = A(x2);
        var b = B(a);
        var c = C(b);
        Console.WriteLine(c);

        Console.WriteLine();

        var f1 = Operators.Square;
        var x3 = new Variable(np.array(2.0));
        var dy = numerical_diff(f1, x3);
        Console.WriteLine(dy);

        Console.WriteLine();
    }

    private static Variable numerical_diff(Func<NDArray, Variable> func, Variable x, double eps = 1e-4)
    {
        var x0 = x.Data - eps;
        var x1 = x.Data + eps;
        var y0 = func(x0);
        var y1 = func(x1);
        return new Variable((y1.Data - y0.Data) / (2.0 * eps));
    }
}