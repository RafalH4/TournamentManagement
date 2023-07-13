namespace TournamentManagement.Models.Domains
{
    public class Match
    {
        public int Id { get; set; }
        public Participant HomeParticipant { get; set; }
        public int HomeParticipantId { get; set; }
        public Participant AwayParticipant { get; set; }
        public int AwayParticipantId { get; set; }
        //public Tournament Tournament { get; set; }
        //public int TournamentId { get; set; }
        public DateTime Date { get; set; }
        public int ScoreHome { get; set; }
        public int ScoreAway { get; set; }
    }
}
