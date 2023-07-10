namespace Application.Interfaces
{
    public interface IEntryRepository<O, P>
    {
        Task<IReadOnlyList<O>> Get(P input);

    }
}
