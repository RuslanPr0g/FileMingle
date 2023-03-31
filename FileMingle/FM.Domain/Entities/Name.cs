namespace FM.Domain.Entities;

public class Name : IValueObject
{
    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("File name should not be empty");
        }
        
        Value = value;
    }

    public string Value { get; }
}