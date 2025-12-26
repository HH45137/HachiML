namespace HachiDeep;

public class Variable<T>
{
    public T Data { get; set; }

    public Variable(T data) => Data = data;
}