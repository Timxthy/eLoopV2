namespace eLoopV2.Models
{
    public class Availability
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
