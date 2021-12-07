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
    public class PisicisController : Controller
    {
        private readonly AdapostContext _context;

        public PisicisController(AdapostContext context)
        {
            _context = context;
        }

        // GET: Pisicis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pisici.ToListAsync());
        }

        // GET: Pisicis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pisici = await _context.Pisici
                .FirstOrDefaultAsync(m => m.PisiciId == id);
            if (pisici == null)
            {
                return NotFound();
            }

            return View(pisici);
        }

        // GET: Pisicis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pisicis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PisiciId,nume_pisica,varsta,culoare")] Pisici pisici)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pisici);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pisici);
        }

        // GET: Pisicis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pisici = await _context.Pisici.FindAsync(id);
            if (pisici == null)
            {
                return NotFound();
            }
            return View(pisici);
        }

        // POST: Pisicis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PisiciId,nume_pisica,varsta,culoare")] Pisici pisici)
        {
            if (id != pisici.PisiciId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pisici);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PisiciExists(pisici.PisiciId))
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
            return View(pisici);
        }

        // GET: Pisicis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pisici = await _context.Pisici
                .FirstOrDefaultAsync(m => m.PisiciId == id);
            if (pisici == null)
            {
                return NotFound();
            }

            return View(pisici);
        }

        // POST: Pisicis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pisici = await _context.Pisici.FindAsync(id);
            _context.Pisici.Remove(pisici);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PisiciExists(int id)
        {
            return _context.Pisici.Any(e => e.PisiciId == id);
        }
    }
}
