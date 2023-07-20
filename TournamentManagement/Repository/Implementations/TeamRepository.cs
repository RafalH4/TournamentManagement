using Microsoft.EntityFrameworkCore;
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

        public async Task Add(Team team)
        {
            await _context.AddAsync(team);
        }

        public Task Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Team>> GetAll()
        {
            return await _context.Teams.ToListAsync();
        }

        public Task Update(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
