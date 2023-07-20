using TournamentManagement.Models.Domains;

namespace TournamentManagement.Repository.Interfaces
{
    public interface ITeamRepository
    {
        Task<Team> GetById(int id);
        Task<List<Team>> GetAll();
        Task Add(Team team);
        Task Update(Team team);
        Task Delete(Team team);
    }
}
