using TournamentManagement.Models.Domains;
using TournamentManagement.Models.DTO.Team;

namespace TournamentManagement.Services.Interfaces
{
    public interface ITeamService
    {
        Task<Team> GetTeamById(int id);
        Task<List<TeamDto>> GetAllTeams();
        Task CreateTeam(CreateTeamDto team);
        Task UpdateTeam(Team team);
        Task DeleteTeam(int id);
    }
}
