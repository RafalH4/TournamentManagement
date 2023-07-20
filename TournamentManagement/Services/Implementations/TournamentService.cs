using TournamentManagement.Models.Domains;
using TournamentManagement.Models.DTO.Tournament;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Services.Implementations
{
    public class TournamentService :ITournamentService
    {
        private readonly IUnitOfWork _repository;

        public TournamentService(IUnitOfWork repository)
        {
            _repository = repository;
        }

        public async Task<Tournament> GetTournamentById(int id)
        {
            return await _repository.TournamentRepository.GetById(id);
        }

        public async Task<List<TournamentDto>> GetAllTournaments()
        {
            var tournaments = await _repository.TournamentRepository.GetAll();
            var tournamentsDto = tournaments.Select(x => new TournamentDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                EndTime = x.EndDate,
                AddedTime = x.AddedTime,
            })
                .ToList();
            return tournamentsDto;
        }

        public async Task CreateTournament(CreateTournamentDto tournament)
        {
            var newTournament = new Tournament()
            {
                Name = tournament.Name,
                StartDate = tournament.StartDate,
                EndDate = tournament.EndDate,
                AddedTime = DateTime.Now
            };
            await _repository.TournamentRepository.Add(newTournament);
            await _repository.Save();
        }

        public async Task UpdateTournament(Tournament tournament)
        {
            await _repository.TournamentRepository.Update(tournament);
            await _repository.Save();
        }

        public async Task DeleteTournament(int id)
        {
            var tournament = await _repository.TournamentRepository.GetById(id);
            if (tournament != null)
            {
                await _repository.TournamentRepository.Delete(tournament);
                await _repository.Save();
            }
        }
    }
}
