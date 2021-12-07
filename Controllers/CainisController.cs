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
    public class CainisController : Controller
    {
        private readonly AdapostContext _context;

        public CainisController(AdapostContext context)
        {
            _context = context;
        }

        // GET: Cainis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caini.ToListAsync());
        }

        // GET: Cainis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caini = await _context.Caini
                .FirstOrDefaultAsync(m => m.CainiId == id);
            if (caini == null)
            {
                return NotFound();
            }

            return View(caini);
        }

        // GET: Cainis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cainis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CainiId,Nume_caine,Varsta,Culoare,Marime")] Caini caini)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caini);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caini);
        }

        // GET: Cainis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caini = await _context.Caini.FindAsync(id);
            if (caini == null)
            {
                return NotFound();
            }
            return View(caini);
        }

        // POST: Cainis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CainiId,Nume_caine,Varsta,Culoare,Marime")] Caini caini)
        {
            if (id != caini.CainiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caini);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CainiExists(caini.CainiId))
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
            return View(caini);
        }

        // GET: Cainis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caini = await _context.Caini
                .FirstOrDefaultAsync(m => m.CainiId == id);
            if (caini == null)
            {
                return NotFound();
            }

            return View(caini);
        }

        // POST: Cainis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caini = await _context.Caini.FindAsync(id);
            _context.Caini.Remove(caini);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CainiExists(int id)
        {
            return _context.Caini.Any(e => e.CainiId == id);
        }
    }
}
