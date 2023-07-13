using TournamentManagement.Repository.Interfaces;

namespace TournamentManagement.Repository.Implementations
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
            TournamentRepository = new TournamentRepository(_context);
            ParticipantRepository = new ParticipantRepository(_context);
            TeamRepository = new TeamRepository(_context);
            MatchRepository = new MatchRepository(_context);
        }

        public ITournamentRepository TournamentRepository { get; }
        public IParticipantRepository ParticipantRepository { get; }
        public ITeamRepository TeamRepository { get; }
        public IMatchRepository MatchRepository { get; }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
