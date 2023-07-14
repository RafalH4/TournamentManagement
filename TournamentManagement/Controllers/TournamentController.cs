using Microsoft.AspNetCore.Mvc;
using TournamentManagement.Models.Domains;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Controllers
{
    public class TournamentController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public TournamentController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        public async Task<IActionResult> Index()
        {
            var tournaments = await _tournamentService.GetAllTournaments();
            return View(tournaments);
        }

        public async Task<IActionResult> Details(int id)
        {
            var tournament = await _tournamentService.GetTournamentById(id);
            if (tournament == null)
            {
                return NotFound();
            }
            return View(tournament);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                await _tournamentService.CreateTournament(tournament);
                return RedirectToAction(nameof(Index));
            }
            return View(tournament);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var tournament = await _tournamentService.GetTournamentById(id);
            if (tournament == null)
            {
                return NotFound();
            }
            return View(tournament);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tournament tournament)
        {
            if (id != tournament.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _tournamentService.UpdateTournament(tournament);
                return RedirectToAction(nameof(Index));
            }

            return View(tournament);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var tournament = await _tournamentService.GetTournamentById(id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _tournamentService.DeleteTournament(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
