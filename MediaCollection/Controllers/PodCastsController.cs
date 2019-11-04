using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediaCollection.Data;
using MediaCollection.Database;

namespace MediaCollection.Controllers
{
    public class PodCastsController : Controller
    {
        private readonly DatabaseContext _context;

        public PodCastsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: PodCasts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Podcasts.ToListAsync());
        }

        // GET: PodCasts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var podCast = await _context.Podcasts
                .FirstOrDefaultAsync(m => m.PodcastID == id);
            if (podCast == null)
            {
                return NotFound();
            }

            return View(podCast);
        }

        // GET: PodCasts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PodCasts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PodcastID,Publisher,Title,StartDate,Poster")] PodCast podCast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(podCast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(podCast);
        }

        // GET: PodCasts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var podCast = await _context.Podcasts.FindAsync(id);
            if (podCast == null)
            {
                return NotFound();
            }
            return View(podCast);
        }

        // POST: PodCasts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PodcastID,Publisher,Title,StartDate,Poster")] PodCast podCast)
        {
            if (id != podCast.PodcastID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(podCast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PodCastExists(podCast.PodcastID))
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
            return View(podCast);
        }

        // GET: PodCasts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var podCast = await _context.Podcasts
                .FirstOrDefaultAsync(m => m.PodcastID == id);
            if (podCast == null)
            {
                return NotFound();
            }

            return View(podCast);
        }

        // POST: PodCasts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var podCast = await _context.Podcasts.FindAsync(id);
            _context.Podcasts.Remove(podCast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PodCastExists(int id)
        {
            return _context.Podcasts.Any(e => e.PodcastID == id);
        }
    }
}
