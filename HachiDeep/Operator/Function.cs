using System.Numerics;
using NumSharp;

namespace HachiDeep.Operator;

public interface IFunction<T>
{
    Variable Call(T value);

    Variable Forward(T value);
}

public abstract class FunctionBase<T> : IFunction<T>
{
    public Variable Call(T value)
    {
        return Forward(value);
    }

    public abstract Variable Forward(T value);
}