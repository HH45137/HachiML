namespace HachiDeep.Operator;

public record Variable<T>(T Data)
{
    public static implicit operator T(Variable<T> value)
    {
        return value.Data;
    }
}