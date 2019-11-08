using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediaCollection.Data;
using MediaCollection.Database;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Security.Claims;

namespace MediaCollection.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DatabaseContext _context;

        public MoviesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index(int? id)
        {
            return View(await _context.Movies.ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Ratings)
                .Include(m => m.Reviews)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MovieID == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieID,Title,Genre,Duration,ReleaseDate,Synopsis,Poster,Director,Cast")] Movie movie, IFormFile newPoster)
        {


            if (ModelState.IsValid)
            {
                if (newPoster != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await newPoster.CopyToAsync(memoryStream);
                        movie.Poster = memoryStream.ToArray();
                    }
                }

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieID,Title,Genre,Duration,ReleaseDate,Synopsis,Poster,Director,Cast")] Movie movie, IFormFile newPoster)
        {
            if (id != movie.MovieID)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    if (newPoster != null)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await newPoster.CopyToAsync(memoryStream);
                            movie.Poster = memoryStream.ToArray();
                        }
                    }

                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.MovieID == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMovieReview(int id, string user, string review)
        {
            MovieReview movieReview = new MovieReview();
            movieReview.MovieReviewID = id;
            movieReview.User = user;
            movieReview.Review = review;

            await _context.SaveChangesAsync();
            return RedirectToAction("Detail");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddRating(int id, int newRating)
        //{
        //    MovieRating rating = new MovieRating();
        //    rating.Rating = newRating;
        //    rating.MovieRatingID = id;
        //    rating.User = User.Identity.Name;

        //    _context.MovieRatings.Add(rating);
        //    await _context.SaveChangesAsync();

        //    return RedirectToAction(nameof(Details));
        //}
    }
}
