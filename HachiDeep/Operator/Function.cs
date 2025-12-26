namespace HachiDeep.Operator;

public interface IFunction<T>
{
    Variable<T> Call(T value);

    Variable<T> Forward(T value);
}

public abstract class FunctionBase<T> : IFunction<T>
{
    public Variable<T> Call(T value)
    {
        return Forward(value);
    }

    public abstract Variable<T> Forward(T value);
}