using Microsoft.AspNetCore.Mvc;
using TournamentManagement.Models.Domains;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllTeams();
            return View(teams);
        }

        public async Task<IActionResult> Details(int id)
        {
            var team = await _teamService.GetTeamById(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            if (ModelState.IsValid)
            {
                await _teamService.CreateTeam(team);
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var team = await _teamService.GetTeamById(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _teamService.UpdateTeam(team);
                return RedirectToAction(nameof(Index));
            }

            return View(team);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var team = await _teamService.GetTeamById(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _teamService.DeleteTeam(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
