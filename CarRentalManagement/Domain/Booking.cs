namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int vechileId { get; set; }
        public int CustomerId { get; set; }
    }
}
