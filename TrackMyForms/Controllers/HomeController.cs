using Microsoft.AspNetCore.Mvc;
using TrackMyForms.Models;
using System.Diagnostics;
using TrackMyForms.Services; // Make sure this matches your namespace

namespace TrackMyForms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFormEntryService _formEntryService;

        public HomeController(ILogger<HomeController> logger, IFormEntryService formEntryService)
        {
            _logger = logger;
            _formEntryService = formEntryService;
        }

        // Display form
        public IActionResult Index()
        {
            return View();
        }

        // Submit form
        [HttpPost]
        public async Task<IActionResult> Index(FormEntry entry)
        {
            if (ModelState.IsValid)
            {
                await _formEntryService.AddAsync(entry);
                return RedirectToAction("ListEntries");
            }
            return View(entry);
        }

        // List all entries
        public async Task<IActionResult> ListEntries()
        {
            var entries = await _formEntryService.GetAllAsync();
            return View(entries);
        }

        // Edit form (GET)
        public async Task<IActionResult> Edit(int id)
        {
            var entry = await _formEntryService.GetByIdAsync(id);
            if (entry == null)
                return NotFound();
            return View(entry);
        }

        // Edit form (POST)
        [HttpPost]
        public async Task<IActionResult> Edit(FormEntry entry)
        {
            if (ModelState.IsValid)
            {
                await _formEntryService.UpdateAsync(entry);
                return RedirectToAction("ListEntries");
            }
            return View(entry);
        }

        // Delete entry
        public async Task<IActionResult> Delete(int id)
        {
            await _formEntryService.DeleteAsync(id);
            return RedirectToAction("ListEntries");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
