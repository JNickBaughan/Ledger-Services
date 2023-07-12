using Core.Entities;

namespace Core.DTO
{
    public class EntryDTO
    {
        public int? EntryId { get; set; }

        public EntryType EntryType { get; set; }

        public int Account { get; set; }

        public int Vendor { get; set; }

        public Double Amount { get; set; }

        public string EntryDescription { get; set; }

        public string Memo { get; set; }

        public DateTime EntryDate { get; set; }

    }
}
