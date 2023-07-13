using TournamentManagement.Models.Domains;

namespace TournamentManagement.Services.Interfaces
{
    public interface ITournamentService
    {
        Task<Tournament> GetTournamentById(int id);
        Task<List<Tournament>> GetAllTournaments();
        Task CreateTournament(Tournament tournament);
        Task UpdateTournament(Tournament tournament);
        Task DeleteTournament(int id);
    }
}
