using Microsoft.AspNetCore.Mvc;
using TournamentManagement.Models.Domains;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Controllers
{
    public class ParticipantController : Controller
    {
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        public async Task<IActionResult> Index()
        {
            var participants = await _participantService.GetAllParticipants();
            return View(participants);
        }

        public async Task<IActionResult> Details(int id)
        {
            var participant = await _participantService.GetParticipantById(id);
            if (participant == null)
            {
                return NotFound();
            }
            return View(participant);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Participant participant)
        {
            if (ModelState.IsValid)
            {
                await _participantService.CreateParticipant(participant);
                return RedirectToAction(nameof(Index));
            }
            return View(participant);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var participant = await _participantService.GetParticipantById(id);
            if (participant == null)
            {
                return NotFound();
            }
            return View(participant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Participant participant)
        {
            if (id != participant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _participantService.UpdateParticipant(participant);
                return RedirectToAction(nameof(Index));
            }

            return View(participant);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var participant = await _participantService.GetParticipantById(id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _participantService.DeleteParticipant(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
