using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModuloInventario.Models;

namespace ModuloInventario.Controllers
{
    public class DEBOLUCIONEQUIPOesController : Controller
    {
        private readonly InventarioContext _context;

        public DEBOLUCIONEQUIPOesController(InventarioContext context)
        {
            _context = context;
        }

        // GET: DEBOLUCIONEQUIPOes
        public async Task<IActionResult> Index()
        {
            return View(await _context.debolucion.ToListAsync());
        }

        // GET: DEBOLUCIONEQUIPOes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dEBOLUCIONEQUIPO = await _context.debolucion
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (dEBOLUCIONEQUIPO == null)
            {
                return NotFound();
            }

            return View(dEBOLUCIONEQUIPO);
        }

        // GET: DEBOLUCIONEQUIPOes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DEBOLUCIONEQUIPOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,TIPO,TIEMPOENTREGA,DETALLE")] DEBOLUCIONEQUIPO dEBOLUCIONEQUIPO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dEBOLUCIONEQUIPO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dEBOLUCIONEQUIPO);
        }

        // GET: DEBOLUCIONEQUIPOes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dEBOLUCIONEQUIPO = await _context.debolucion.FindAsync(id);
            if (dEBOLUCIONEQUIPO == null)
            {
                return NotFound();
            }
            return View(dEBOLUCIONEQUIPO);
        }

        // POST: DEBOLUCIONEQUIPOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,TIPO,TIEMPOENTREGA,DETALLE")] DEBOLUCIONEQUIPO dEBOLUCIONEQUIPO)
        {
            if (id != dEBOLUCIONEQUIPO.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dEBOLUCIONEQUIPO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DEBOLUCIONEQUIPOExists(dEBOLUCIONEQUIPO.SECUENCIAL))
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
            return View(dEBOLUCIONEQUIPO);
        }

        // GET: DEBOLUCIONEQUIPOes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dEBOLUCIONEQUIPO = await _context.debolucion
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (dEBOLUCIONEQUIPO == null)
            {
                return NotFound();
            }

            return View(dEBOLUCIONEQUIPO);
        }

        // POST: DEBOLUCIONEQUIPOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dEBOLUCIONEQUIPO = await _context.debolucion.FindAsync(id);
            _context.debolucion.Remove(dEBOLUCIONEQUIPO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DEBOLUCIONEQUIPOExists(int id)
        {
            return _context.debolucion.Any(e => e.SECUENCIAL == id);
        }
    }
}
