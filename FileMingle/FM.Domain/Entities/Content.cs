namespace FM.Domain.Entities;

public class Content : IValueObject
{
    public Content(byte[] value)
    {
        Value = value;
    }
    
    public byte[] Value { get; }
}