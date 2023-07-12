namespace Core.Entities
{
    public class Entry
    {
        public int EntryId { get; set; }

        // https://www.codeproject.com/Articles/41746/Mapping-NET-Enumerations-to-the-Database
        public EntryType EntryType { get; set; }

        public int Account { get; set; } 
        
        public int Vendor { get; set; }

        // https://sqlblog.org/2008/04/27/performance-storage-comparisons-money-vs-decimal
        public Double Amount { get; set; }

        public string EntryDescription { get; set; }

        public string Memo {  get ; set; }

        public DateTime EntryDate { get; set; }

    }
}