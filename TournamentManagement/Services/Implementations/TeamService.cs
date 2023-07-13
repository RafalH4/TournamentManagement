using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<Team> GetTeamById(int id)
        {
            return await _teamRepository.GetById(id);
        }

        public async Task<List<Team>> GetAllTeams()
        {
            // return await _teamRepository.GetAll();
            return null;
        }

        public async Task CreateTeam(Team team)
        {
            await _teamRepository.Add(team);
        }

        public async Task UpdateTeam(Team team)
        {
            await _teamRepository.Update(team);
        }

        public async Task DeleteTeam(int id)
        {
            var team = await _teamRepository.GetById(id);
            if (team != null)
            {
                await _teamRepository.Delete(team);
            }
        }
    }
}
