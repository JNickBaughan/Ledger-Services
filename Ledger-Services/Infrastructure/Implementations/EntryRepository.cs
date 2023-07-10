using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Application.Interfaces;
using Core.Entities;
using Core.Model;
using Dapper;
using SQL.Queries;

namespace Implementations.Repository
{
    public class EntryRepository : IEntryRepository<Entry, EntrySearch>
    {
        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public EntryRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }



        async Task<IReadOnlyList<Entry>> IEntryRepository<Entry, EntrySearch>.Get(EntrySearch search)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
            
                connection.Open();
                var result = await connection.QueryAsync<Entry>(EntryQueries.EntrySearchQuery, new { 
                    StartDate = search.StartDate,
                    EndDate = search.EndDate
                });
                return result.ToList();

            }
        }

        #endregion

        #region ===[ IEntryRepository Methods ]==================================================











        #endregion

    }
}
