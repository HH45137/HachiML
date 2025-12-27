using System;
using NumSharp;

namespace HachiDeep.Operator;

public class Square : FunctionBase<NDArray>
{
    public override Variable Forward(NDArray value)
    {
        return new Variable(np.square(value));
    }
}

public class Exp : FunctionBase<NDArray>
{
    public override Variable Forward(NDArray value)
    {
        return new Variable(np.exp(value));
    }
}

public static class Operators
{
    public static readonly Func<NDArray, Variable> Square = new Square().Call;
    public static readonly Func<NDArray, Variable> Exp = new Exp().Call;
}