using Application.Interfaces;
using Core.Entities;
using Core.DTO;
using Implementations.Repository;
using Infrastructure.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEntryRepository, EntryRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
