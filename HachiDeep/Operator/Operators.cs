using NumSharp;

namespace HachiDeep.Operator;

public class Square : FunctionBase<double>
{
    public override Variable<double> Forward(double value)
    {
        return new Variable<double>(value * value);
    }
}

public class Exp : FunctionBase<double>
{
    public override Variable<double> Forward(double value)
    {
        return new Variable<double>(np.exp(value));
    }
}

public static class Operators
{
    public static readonly Func<double, Variable<double>> Square = new Square().Call;
    public static readonly Func<double, Variable<double>> Exp = new Exp().Call;
}