namespace TournamentManagement.Models.Domains
{
    public class Participant : Entity
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        public List<Match> MatchesAsHost { get; set; }
        public List<Match> MatchesAsGuest { get; set; }
    }
}
