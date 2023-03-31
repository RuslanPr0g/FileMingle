namespace FM.Domain;

public abstract class AggregateRoot
{
    public AggregateRoot(Guid id)
    {
        Id = id;
    }
    
    public Guid Id { get; }
}