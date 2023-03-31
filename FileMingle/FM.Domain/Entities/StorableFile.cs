namespace FM.Domain.Entities;

public sealed class StorableFile : AggregateRoot
{
    public StorableFile(Guid id, Name name, Content content) : base(id)
    {
        Name = name;
        Content = content;
    }

    public Name Name { get; }
    public Content Content { get; }
}