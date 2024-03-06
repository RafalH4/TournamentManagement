using TournamentManagement.Models.Domains;
using TournamentManagement.Models.DTO.Tournament;

namespace TournamentManagement.Services.Interfaces
{
    public interface ITournamentService
    {
        Task<Tournament> GetTournamentById(int id);
        Task<TournamentDto> GetTournamentDetails(int id);
        Task<List<TournamentDto>> GetAllTournaments();
        Task CreateTournament(CreateTournamentDto tournament);
        Task UpdateTournament(Tournament tournament);
        Task DeleteTournament(int id);
    }
}
