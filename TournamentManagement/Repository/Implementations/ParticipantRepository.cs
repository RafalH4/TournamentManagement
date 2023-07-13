using TournamentManagement.Models.Domains;
using TournamentManagement.Repository.Interfaces;

namespace TournamentManagement.Repository.Implementations
{
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly Context _context;
        public ParticipantRepository(Context context)
        {
            _context = context;
        }

        public Task Add(Participant participant)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Participant participant)
        {
            throw new NotImplementedException();
        }

        public Task<Participant> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Participant participant)
        {
            throw new NotImplementedException();
        }
    }
}
