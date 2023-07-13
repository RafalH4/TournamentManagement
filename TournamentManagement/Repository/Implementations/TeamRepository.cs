using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;

namespace TournamentManagement.Repository.Implementations
{
    public class TeamRepository : ITeamRepository
    {
        private readonly Context _context;
        public TeamRepository(Context context)
        {
            _context = context;
        }

        public Task Add(Team team)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
