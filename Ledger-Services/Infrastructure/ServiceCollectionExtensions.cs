using Application.Interfaces;
using Core.Entities;
using Core.Model;
using Implementations.Repository;
using Infrastructure.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEntryRepository<Entry, EntrySearch>, EntryRepository>();
            services.AddTransient<IUnitOfWork<Entry, EntrySearch>, UnitOfWork<Entry, EntrySearch>>();
        }
    }
}
