using System;
using HachiDeep;
using NumSharp;

namespace AutoDifferential
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--------== Hello Hachi-Deep Machine Learning Framework! ==--------\n");

            var data = np.array([[1.2, 2.5, 6.2], [1, 6, 9]]);
            var x = new Variable<NDArray>(data);
            Console.WriteLine($"value = {x.Data}");
            Console.WriteLine($"dim = {x.Data.ndim}");

            var x1 = new Variable<double>(8.0);
            Console.WriteLine("Value square = " + x1.Square().Data);
        }
    }
};