using TournamentManagement.Models.DTO.Team;

namespace TournamentManagement.Models.DTO.Tournament
{
    public class CreateTournamentDto
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
