using TournamentManagement.Models.Domains;

namespace TournamentManagement.Services.Interfaces
{
    public interface IParticipantService
    {
        Task<Participant> GetParticipantById(int id);
        Task<List<Participant>> GetAllParticipants();
        Task CreateParticipant(Participant participant);
        Task UpdateParticipant(Participant participant);
        Task DeleteParticipant(int id);
    }
}
