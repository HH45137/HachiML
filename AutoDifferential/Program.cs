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
        var x0 = new Variable<NDArray>(data);
        Console.WriteLine($"value = {x0.Data}");
        Console.WriteLine($"dim = {x0.Data.ndim}");

        Console.WriteLine();

        var x1 = new Variable<double>(10.0);
        var f = new Square().Call;
        var y1 = f(x1);
        Console.WriteLine(y1.Data.GetType());
        Console.WriteLine(y1);

        Console.WriteLine();

        var A = Operators.Square;
        var B = Operators.Exp;
        var C = Operators.Square;
        var x2 = new Variable<double>(.5);

        var a = A(x2);
        var b = B(a);
        var c = C(b);

        Console.WriteLine(c);
    }
}