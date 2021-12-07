using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Heaven;
using Heaven.Models;

namespace Heaven.Controllers
{
    public class PozesController : Controller
    {
        private readonly AdapostContext _context;

        public PozesController(AdapostContext context)
        {
            _context = context;
        }

        // GET: Pozes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poze.ToListAsync());
        }

        // GET: Pozes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poze = await _context.Poze
                .FirstOrDefaultAsync(m => m.PozeId == id);
            if (poze == null)
            {
                return NotFound();
            }

            return View(poze);
        }

        // GET: Pozes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pozes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PozeId,id_pisica,id_caine")] Poze poze)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poze);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poze);
        }

        // GET: Pozes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poze = await _context.Poze.FindAsync(id);
            if (poze == null)
            {
                return NotFound();
            }
            return View(poze);
        }

        // POST: Pozes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PozeId,id_pisica,id_caine")] Poze poze)
        {
            if (id != poze.PozeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poze);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PozeExists(poze.PozeId))
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
            return View(poze);
        }

        // GET: Pozes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poze = await _context.Poze
                .FirstOrDefaultAsync(m => m.PozeId == id);
            if (poze == null)
            {
                return NotFound();
            }

            return View(poze);
        }

        // POST: Pozes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poze = await _context.Poze.FindAsync(id);
            _context.Poze.Remove(poze);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PozeExists(int id)
        {
            return _context.Poze.Any(e => e.PozeId == id);
        }
    }
}
