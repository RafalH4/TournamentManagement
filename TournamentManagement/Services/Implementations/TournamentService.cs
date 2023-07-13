using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Services.Implementations
{
    public class TournamentService :ITournamentService
    {
        private readonly ITournamentRepository _tournamentRepository;

        public TournamentService(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        public async Task<Tournament> GetTournamentById(int id)
        {
            return await _tournamentRepository.GetById(id);
        }

        public async Task<List<Tournament>> GetAllTournaments()
        {
            return await _tournamentRepository.GetAll();
        }

        public async Task CreateTournament(Tournament tournament)
        {
            await _tournamentRepository.Add(tournament);
        }

        public async Task UpdateTournament(Tournament tournament)
        {
            await _tournamentRepository.Update(tournament);
        }

        public async Task DeleteTournament(int id)
        {
            var tournament = await _tournamentRepository.GetById(id);
            if (tournament != null)
            {
                await _tournamentRepository.Delete(tournament);
            }
        }
    }
}
