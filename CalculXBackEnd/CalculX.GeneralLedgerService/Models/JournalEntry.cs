namespace CalculX.GeneralLedgerService.Models
{
    public class JournalEntry
    {
        public int JournalEntryId { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
