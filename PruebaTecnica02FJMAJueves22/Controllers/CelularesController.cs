using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica02FJMAJueves22.Models;

namespace PruebaTecnica02FJMAJueves22.Controllers
{
    public class CelularesController : Controller
    {
        private readonly PruebaTecnica02FJMAContext _context;

        public CelularesController(PruebaTecnica02FJMAContext context)
        {
            _context = context;
        }

        // GET: Celulares
        public async Task<IActionResult> Index()
        {
              return _context.Celulares != null ? 
                          View(await _context.Celulares.ToListAsync()) :
                          Problem("Entity set 'PruebaTecnica02FJMAContext.Celulares'  is null.");
        }

        // GET: Celulares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Celulares == null)
            {
                return NotFound();
            }

            var celulares = await _context.Celulares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celulares == null)
            {
                return NotFound();
            }

            return View(celulares);
        }

        // GET: Celulares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Celulares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Precio,Imagen,MarcaId")] Celulares celulares)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celulares);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(celulares);
        }

        // GET: Celulares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Celulares == null)
            {
                return NotFound();
            }

            var celulares = await _context.Celulares.FindAsync(id);
            if (celulares == null)
            {
                return NotFound();
            }
            return View(celulares);
        }

        // POST: Celulares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Precio,Imagen,MarcaId")] Celulares celulares)
        {
            if (id != celulares.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celulares);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelularesExists(celulares.Id))
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
            return View(celulares);
        }

        // GET: Celulares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Celulares == null)
            {
                return NotFound();
            }

            var celulares = await _context.Celulares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celulares == null)
            {
                return NotFound();
            }

            return View(celulares);
        }

        // POST: Celulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Celulares == null)
            {
                return Problem("Entity set 'PruebaTecnica02FJMAContext.Celulares'  is null.");
            }
            var celulares = await _context.Celulares.FindAsync(id);
            if (celulares != null)
            {
                _context.Celulares.Remove(celulares);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelularesExists(int id)
        {
          return (_context.Celulares?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
