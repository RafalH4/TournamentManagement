namespace TournamentManagement.Models.Domains
{
    public class Team : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Participant> Participants { get; set; }
    }
}
