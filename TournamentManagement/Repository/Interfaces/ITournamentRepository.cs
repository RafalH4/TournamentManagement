using TournamentManagement.Models.Domains;

namespace TournamentManagement.Repository.Interfaces
{
    public interface ITournamentRepository
    {
        Task<Tournament> GetById(int id);
        Task<List<Tournament>> GetAll();
        Task Add(Tournament tournament);
        Task Update(Tournament tournament);
        Task Delete(Tournament tournament);
    }
}
