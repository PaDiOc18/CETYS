using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PFPOO.Models;

namespace PFPOO.Controllers
{
    public class TesController : Controller
    {
        private readonly PFPOOContext _context;

        public TesController(PFPOOContext context)
        {
            _context = context;
        }

        // GET: Tes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Te.ToListAsync());
        }

        // GET: Tes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var te = await _context.Te
                .FirstOrDefaultAsync(m => m.Id == id);
            if (te == null)
            {
                return NotFound();
            }

            return View(te);
        }

        // GET: Tes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sabor,EndulzanteR,InStock,Precio")] Te te)
        {
            if (ModelState.IsValid)
            {
                _context.Add(te);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(te);
        }

        // GET: Tes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var te = await _context.Te.FindAsync(id);
            if (te == null)
            {
                return NotFound();
            }
            return View(te);
        }

        // POST: Tes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sabor,EndulzanteR,InStock,Precio")] Te te)
        {
            if (id != te.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(te);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeExists(te.Id))
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
            return View(te);
        }

        // GET: Tes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var te = await _context.Te
                .FirstOrDefaultAsync(m => m.Id == id);
            if (te == null)
            {
                return NotFound();
            }

            return View(te);
        }

        // POST: Tes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var te = await _context.Te.FindAsync(id);
            _context.Te.Remove(te);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeExists(int id)
        {
            return _context.Te.Any(e => e.Id == id);
        }
    }
}
