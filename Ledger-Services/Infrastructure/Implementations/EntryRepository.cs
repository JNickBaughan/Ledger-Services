using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Application.Interfaces;
using Core.Entities;
using Core.DTO;
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



        public async Task<IReadOnlyList<Entry>> Get(EntrySearchDTO search)
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

        public async Task<int> Add(EntryDTO entry)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {

                connection.Open();
                var result = await connection.QueryAsync<Entry>(EntryQueries.AddEntry, new
                {
                    @EntryType = entry.EntryType.ToString(),
                    @Account = entry.Account,
                    @Vendor = entry.Vendor,
                    @EntryDescription = entry.EntryDescription,
                    @EntryDate = entry.EntryDate,
                    @Memo = entry.Memo,
                    @Amount = entry.Amount
                });

            }
            return 1;
        }


        #endregion

        #region ===[ IEntryRepository Methods ]==================================================











        #endregion

    }
}
