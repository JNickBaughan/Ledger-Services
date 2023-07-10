
using Application.Interfaces;
using Implementations.Repository;

namespace Infrastructure.Implementations
{
    public class UnitOfWork<O, P> : IUnitOfWork<O, P>
    {
        public UnitOfWork(IEntryRepository<O, P> EntryRepository)
        {
            Entries = EntryRepository;
        }

        public IEntryRepository<O, P> Entries { get; set; }

    }

}
