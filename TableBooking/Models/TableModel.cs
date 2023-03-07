namespace TableBooking.Models
{
    public class TableModel
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }

        public int TableNumber { get; set; }

        public bool IsBooked { get; set; }

        public DateTime DateTimeBooked { get; set; }

        public string? GuestName { get; set; }
        public string? GuestEmail { get; set; }
    }
}
