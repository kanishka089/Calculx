namespace CalculX.GeneralLedgerService.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public ICollection<JournalEntry> JournalEntries { get; set; }
    }
}
