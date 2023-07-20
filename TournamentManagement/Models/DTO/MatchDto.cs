﻿namespace TournamentManagement.Models.DTO
{
    public class MatchDto
    {
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
    }
}
