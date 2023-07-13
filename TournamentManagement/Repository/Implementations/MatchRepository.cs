using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;

namespace TournamentManagement.Repository.Implementations
{
    public class MatchRepository : IMatchRepository
    {
        private readonly Context _context;
        public MatchRepository(Context context)
        {
            _context = context;
        }

        public Task Add(Match match)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Match match)
        {
            throw new NotImplementedException();
        }

        public Task<Match> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Match match)
        {
            throw new NotImplementedException();
        }
    }
}
