using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Application.Interfaces;
using Core.Entities;
using Dapper;
using SQL.Queries;

namespace Implementations.Repository
{
    public class EntryRepository : IEntryRepository
    {
        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public EntryRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        Task<string> IRepository<Entry>.AddAsync(Entry entity)
        {
            throw new NotImplementedException();
        }

        Task<string> IRepository<Entry>.DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<Entry>> IRepository<Entry>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        async Task<Entry> IRepository<Entry>.GetByIdAsync(long entryId)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Entry>(EntryQueries.EntryById, new { EntryId = entryId });
                return result;
            }
        }

        Task<string> IRepository<Entry>.UpdateAsync(Entry entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ===[ IEntryRepository Methods ]==================================================











        #endregion

    }
}
