
namespace TournamentManagement.Models.Domains
{
    public class Tournament : Entity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Match> Matches { get; set; }
    }
}
