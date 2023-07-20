using TournamentManagement.Models.Domains;
using TournamentManagement.Models.DTO.Team;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _repository;

        public TeamService(IUnitOfWork repository)
        {
            _repository = repository;
        }

        public async Task<Team> GetTeamById(int id)
        {
            return await _repository.TeamRepository.GetById(id);
        }

        public async Task<List<TeamDto>> GetAllTeams()
        {
            var teams = await _repository.TeamRepository.GetAll();
            var teamsDto = teams.Select(x => new TeamDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToList();
            return teamsDto;
        }

        public async Task CreateTeam(CreateTeamDto team)
        {
            var newTeam = new Team()
            {
                Name = team.Name,
                Description = team.Description,
                AddedTime = DateTime.Now
            };
            await _repository.TeamRepository.Add(newTeam);
            await _repository.Save();
        }

        public async Task UpdateTeam(Team team)
        {
            await _repository.TeamRepository.Update(team);
        }

        public async Task DeleteTeam(int id)
        {
            var team = await _repository.TeamRepository.GetById(id);
            if (team != null)
            {
                await _repository.TeamRepository.Delete(team);
            }
        }
    }
}
