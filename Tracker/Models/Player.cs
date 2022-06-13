using System.ComponentModel.DataAnnotations;

namespace Tracker.Models
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public List<Match> Matches { get; set; } = new List<Match>();
    }
}
