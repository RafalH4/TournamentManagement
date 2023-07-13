using TournamentManagement.Models.Domains;

namespace TournamentManagement.Repository.Interfaces
{
    public interface IParticipantRepository
    {
        Task<Participant> GetById(int id);
        Task Add(Participant participant);
        Task Update(Participant participant);
        Task Delete(Participant participant);
    }
}
