namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        IEntryRepository Entries { get; }
    }
}
