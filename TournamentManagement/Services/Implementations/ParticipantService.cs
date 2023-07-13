using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Services.Implementations
{
    public class ParticipantService :IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        public async Task<Participant> GetParticipantById(int id)
        {
            return await _participantRepository.GetById(id);
        }

        public async Task<List<Participant>> GetAllParticipants()
        {
            //return await _participantRepository.GetAll();
            return null;
        }

        public async Task CreateParticipant(Participant participant)
        {
            await _participantRepository.Add(participant);
        }

        public async Task UpdateParticipant(Participant participant)
        {
            await _participantRepository.Update(participant);
        }

        public async Task DeleteParticipant(int id)
        {
            var participant = await _participantRepository.GetById(id);
            if (participant != null)
            {
                await _participantRepository.Delete(participant);
            }
        }
    }
}
