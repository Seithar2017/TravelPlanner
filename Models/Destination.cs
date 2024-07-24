using System.Collections.Generic;
using System.Diagnostics;

namespace TravelPlanner.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TripId { get; set; }
        public Trip Trip { get; set; } = new Trip();
        public ICollection<Activity> Activities { get; set; } = new List<Activity>();
    }
}
