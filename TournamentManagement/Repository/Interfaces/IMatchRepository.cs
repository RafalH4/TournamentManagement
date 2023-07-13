using TournamentManagement.Models.Domains;

namespace TournamentManagement.Repository.Interfaces
{
    public interface IMatchRepository
    {
        Task<Match> GetById(int id);
        Task Add(Match match);
        Task Update(Match match);
        Task Delete(Match match);
    }
}
