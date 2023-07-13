using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;

namespace TournamentManagement.Repository.Implementations
{
    public class TournamentRepository : ITournamentRepository
    {
        private readonly Context _context;
        public TournamentRepository(Context context)
        {
            _context = context;
        }

        public Task Add(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public Task<Tournament> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Tournament tournament)
        {
            throw new NotImplementedException();
        }
    }
}
