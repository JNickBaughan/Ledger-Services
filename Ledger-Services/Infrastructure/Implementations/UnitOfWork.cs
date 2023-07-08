
using Application.Interfaces;
using Implementations.Repository;

namespace Infrastructure.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IEntryRepository EntryRepository)
        {
            Entries = EntryRepository;
        }

        public IEntryRepository Entries { get; set; }

    }

}
