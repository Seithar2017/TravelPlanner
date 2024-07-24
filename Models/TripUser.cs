namespace TravelPlanner.Models
{
    public class TripUser
    {
        public int TripId { get; set; }
        public Trip Trip { get; set; } = new Trip();

        public int UserId { get; set; }
        public User User { get; set; } = new User();
    }
}