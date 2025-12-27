using NumSharp;

namespace HachiDeep.Operator;

public record Variable(NDArray Data)
{
    public static implicit operator NDArray(Variable value)
    {
        return value.Data;
    }

    public static implicit operator string(Variable value)
    {
        return value.Data.ToString();
    }
}