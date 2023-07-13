using TournamentManagement.Models.Domains;

namespace TournamentManagement.Services.Interfaces
{
    public interface ITeamService
    {
        Task<Team> GetTeamById(int id);
        Task<List<Team>> GetAllTeams();
        Task CreateTeam(Team team);
        Task UpdateTeam(Team team);
        Task DeleteTeam(int id);
    }
}
