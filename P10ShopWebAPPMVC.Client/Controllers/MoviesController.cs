using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieModel;


namespace P09ShopWebAPPMVC.Client.Controllers
{
    public class MoviesController : Controller
    {

        private readonly IMovieService _MovieService;


        private readonly ILogger<MoviesController> _logger;

        public MoviesController(IMovieService MovieService, ILogger<MoviesController> logger)
        {
            _MovieService = MovieService;
            _logger = logger;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            var Movies = await _MovieService.GetMoviesAsync();

            return Movies != null ?
                          View(Movies.Data.AsEnumerable()) :
                          Problem("Entity set 'ShopContext.Movies'  is null.");

            //return Movies != null ? 
            //              View("~/Views/Movies/Index.cshtml", Movies.Data.AsEnumerable()) :
            //              Problem("Entity set 'ShopContext.Movies'  is null.");
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var Movie = await _MovieService.GetMovieByIdAsync((int)id);

            if (Movie.Data == null)
            {
                return NotFound();
            }

            return View(Movie.Data);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Director")] Movie Movie)
        {

            if (ModelState.IsValid)
            {
                await _MovieService.CreateMovieAsync(Movie);
                return RedirectToAction(nameof(Index));
            }
            return View(Movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var Movie = await _MovieService.GetMovieByIdAsync((int)id);
            if (Movie.Data == null)
            {
                return NotFound();
            }
            return View(Movie.Data);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Director")] Movie Movie)
        {

            if (id != Movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var MovieResult = await _MovieService.UpdateMovieAsync(Movie);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var Movie = await _MovieService.GetMovieByIdAsync((int)id);
            if (Movie == null)
            {
                return NotFound();
            }

            return View(Movie.Data);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Movie = await _MovieService.DeleteMovieAsync((int)id);
            if (Movie.Success)
                return RedirectToAction(nameof(Index));
            else
                return NotFound();

        }

    }
}
