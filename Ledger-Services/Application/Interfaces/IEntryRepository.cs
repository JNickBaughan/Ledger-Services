using Core.Entities;
using Core.DTO;

namespace Application.Interfaces
{
    public interface IEntryRepository
    {
        Task<IReadOnlyList<Entry>> Get(EntrySearchDTO entrySearch);

        Task<int> Add(EntryDTO entry);

    }
}
