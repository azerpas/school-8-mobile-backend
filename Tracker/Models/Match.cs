using System.ComponentModel.DataAnnotations;

namespace Tracker.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public List<Set> Sets { get; set; } = new List<Set>();
    }
    
    public class Game
    {
        public int ScorePlayer1 { get; set; } = 0;
        public int ScorePlayer2 { get; set; } = 0;
    }

    public class Set
    {
        public int GamesWonPlayer1 { get; set; } = 0;
        public int GamesWonPlayer2 { get; set; } = 0;
    }
}
