using TournamentManagement.Models.Domains;

namespace TournamentManagement.Services.Interfaces
{
    public interface IMatchService
    {
        Task<Match> GetMatchById(int id);
        Task<List<Match>> GetAllMatches();
        Task CreateMatch(Match match);
        Task UpdateMatch(Match match);
        Task DeleteMatch(int id);
    }
}
