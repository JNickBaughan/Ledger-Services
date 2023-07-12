using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Queries
{
    public static class EntryQueries
    {
        public static string EntrySearchQuery => @"SELECT * FROM [Entries] (NOLOCK) WHERE [EntryDate] >= @StartDate AND [EntryDate] <= @EndDate";

        public static string AddEntry =>
            @"INSERT INTO [Entries] ([EntryType],
	                                [Account],
	                                [Vendor],
                                    [EntryDescription],
                                    [EntryDate],
                                    [Memo],
                                    [Amount]) 
            VALUES (@EntryType, @Account,@Vendor,@EntryDescription,@EntryDate,@Memo,@Amount)";

        public static string UpdateEntry =>
            @"UPDATE [Entries] 
            SET [EntryType] = @EntryType,
	            [Account] = @Account,
	            [Vendor] = @Vendor,
                [EntryDescription] = @EntryDescription,
                [EntryDate] = @EntryDate,
                [Memo] = @Memo,
                [Amount] = @Amount
        WHERE [EntryId] = @EntryId";

        public static string DeleteContact => "DELETE FROM [Entry] WHERE [EntryId] = @EntryId";
    }
}
