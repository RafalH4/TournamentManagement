namespace TournamentManagement.Repository.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        ITournamentRepository TournamentRepository { get; }
        IParticipantRepository ParticipantRepository { get; }
        ITeamRepository TeamRepository { get; }
        IMatchRepository MatchRepository { get; }
        Task Save();
    }
}
