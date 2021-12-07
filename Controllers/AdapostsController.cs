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
    public class AdapostsController : Controller
    {
        private readonly AdapostContext _context;

        public AdapostsController(AdapostContext context)
        {
            _context = context;
        }

        // GET: Adaposts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adaposts.ToListAsync());
        }

        // GET: Adaposts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adapost = await _context.Adaposts
                .FirstOrDefaultAsync(m => m.AdapostId == id);
            if (adapost == null)
            {
                return NotFound();
            }

            return View(adapost);
        }

        // GET: Adaposts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adaposts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdapostId,denumire,adresa,oras")] Adapost adapost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adapost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adapost);
        }

        // GET: Adaposts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adapost = await _context.Adaposts.FindAsync(id);
            if (adapost == null)
            {
                return NotFound();
            }
            return View(adapost);
        }

        // POST: Adaposts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdapostId,denumire,adresa,oras")] Adapost adapost)
        {
            if (id != adapost.AdapostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adapost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdapostExists(adapost.AdapostId))
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
            return View(adapost);
        }

        // GET: Adaposts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adapost = await _context.Adaposts
                .FirstOrDefaultAsync(m => m.AdapostId == id);
            if (adapost == null)
            {
                return NotFound();
            }

            return View(adapost);
        }

        // POST: Adaposts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adapost = await _context.Adaposts.FindAsync(id);
            _context.Adaposts.Remove(adapost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdapostExists(int id)
        {
            return _context.Adaposts.Any(e => e.AdapostId == id);
        }
    }
}
