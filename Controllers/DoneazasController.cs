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
    public class DoneazasController : Controller
    {
        private readonly AdapostContext _context;

        public DoneazasController(AdapostContext context)
        {
            _context = context;
        }

        // GET: Doneazas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doneaza.ToListAsync());
        }

        // GET: Doneazas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doneaza = await _context.Doneaza
                .FirstOrDefaultAsync(m => m.DoneazaId == id);
            if (doneaza == null)
            {
                return NotFound();
            }

            return View(doneaza);
        }

        // GET: Doneazas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doneazas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoneazaId,Numele detinatorului,Numarul cardului,Data de expirare,CVC")] Doneaza doneaza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doneaza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doneaza);
        }

        // GET: Doneazas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doneaza = await _context.Doneaza.FindAsync(id);
            if (doneaza == null)
            {
                return NotFound();
            }
            return View(doneaza);
        }

        // POST: Doneazas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoneazaId,Numele_detinatorului,Numarul_cardului,Data_deexpirare,CVC")] Doneaza doneaza)
        {
            if (id != doneaza.DoneazaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doneaza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoneazaExists(doneaza.DoneazaId))
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
            return View(doneaza);
        }

        // GET: Doneazas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doneaza = await _context.Doneaza
                .FirstOrDefaultAsync(m => m.DoneazaId == id);
            if (doneaza == null)
            {
                return NotFound();
            }

            return View(doneaza);
        }

        // POST: Doneazas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doneaza = await _context.Doneaza.FindAsync(id);
            _context.Doneaza.Remove(doneaza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoneazaExists(int id)
        {
            return _context.Doneaza.Any(e => e.DoneazaId == id);
        }
    }
}
