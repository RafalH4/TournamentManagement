using Microsoft.AspNetCore.Mvc;
using TournamentManagement.Models.Domains;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public async Task<IActionResult> Index()
        {
            var matches = await _matchService.GetAllMatches();
            return View(matches);
        }

        public async Task<IActionResult> Details(int id)
        {
            var match = await _matchService.GetMatchById(id);
            if (match == null)
            {
                return NotFound();
            }
            return View(match);
        }

        public IActionResult Create()
        {
            //ViewBag.ParticipantList = await _matchService.GetParticipantList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Match match)
        {
            if (ModelState.IsValid)
            {
                await _matchService.CreateMatch(match);
                return RedirectToAction(nameof(Index));
            }

            //ViewBag.ParticipantList = await _matchService.GetParticipantList();
            return View(match);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var match = await _matchService.GetMatchById(id);
            if (match == null)
            {
                return NotFound();
            }

            //ViewBag.ParticipantList = await _matchService.GetParticipantList();
            return View(match);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Match match)
        {
            if (id != match.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _matchService.UpdateMatch(match);
                return RedirectToAction(nameof(Index));
            }

            //ViewBag.ParticipantList = await _matchService.GetParticipantList();
            return View(match);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var match = await _matchService.GetMatchById(id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _matchService.DeleteMatch(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
