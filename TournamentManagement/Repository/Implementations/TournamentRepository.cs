using Microsoft.EntityFrameworkCore;
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

        public async Task Add(Tournament tournament)
        {
            await _context.AddAsync(tournament);
        }

        public Task Delete(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public async Task<Tournament> GetById(int id)
        {
            return _context.Tournaments.SingleOrDefault(x => x.Id == id);
        }
        public async Task<List<Tournament>> GetAll()
        {
            return await _context.Tournaments.ToListAsync();
        }

        public Task Update(Tournament tournament)
        {
            throw new NotImplementedException();
        }
    }
}
