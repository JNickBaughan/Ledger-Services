namespace Application.Interfaces
{
    public interface IUnitOfWork<O, P>
    {
        IEntryRepository<O, P> Entries { get; }
    }
}
