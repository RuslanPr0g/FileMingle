namespace FM.Domain.Entities;

public sealed class File : AggregateRoot
{
    public File(Guid id, Name name, Content content) : base(id)
    {
        Name = name;
        Content = content;
    }

    public Name Name { get; }
    public Content Content { get; }
}