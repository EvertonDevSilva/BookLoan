namespace BookLoan.Entities
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string Receiver { get; set; } = string.Empty;
        public DateTime LoanDate { get; set; } = DateTime.Now;
    }
}
