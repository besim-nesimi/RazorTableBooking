namespace TableBooking.Models
{
    public class TableModel
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }

        public int TableNumber { get; set; }

        public bool IsBooked { get; set; }
    }
}
