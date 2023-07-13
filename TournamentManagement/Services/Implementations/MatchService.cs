using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Services.Implementations
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;

        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<Match> GetMatchById(int id)
        {
            return await _matchRepository.GetById(id);
        }

        public async Task<List<Match>> GetAllMatches()
        {
            //return await _matchRepository();
            return null;
        }

        public async Task CreateMatch(Match match)
        {
            await _matchRepository.Add(match);
        }

        public async Task UpdateMatch(Match match)
        {
            await _matchRepository.Update(match);
        }

        public async Task DeleteMatch(int id)
        {
            var match = await _matchRepository.GetById(id);
            if (match != null)
            {
                await _matchRepository.Delete(match);
            }
        }
    }
}
