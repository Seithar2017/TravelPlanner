namespace TravelPlanner.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DestinationId { get; set; }
        public Destination Destination { get; set; } = new Destination();
    }
}
