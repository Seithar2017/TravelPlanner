using System.Collections.Generic;

namespace TravelPlanner.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public ICollection<Destination> Destinations { get; set; } = new List<Destination>();
        public ICollection<TripUser> TripUsers { get; set; } = new List<TripUser>();
    }
}