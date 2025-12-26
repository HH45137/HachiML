namespace HachiDeep;

public interface IFunction<T>
{
    Variable<T> Call(Variable<T> value);
}

public static class FunctionExtensions
{
    public static Variable<double> Square(this Variable<double> value) => new SquareFunction().Call(value);
}

public sealed class SquareFunction : IFunction<double>
{
    public Variable<double> Call(Variable<double> value)
    {
        var x = value.Data;
        var y = x * x;
        return new Variable<double>(y);
    }
}