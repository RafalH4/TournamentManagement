namespace TournamentManagement.Models.DTO.Tournament
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime AddedTime { get; set; }

    }
}
