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
    public class ASIGNACIONCOMPUTADORESController : Controller
    {
        private readonly InventarioContext _context;

        public ASIGNACIONCOMPUTADORESController(InventarioContext context)
        {
            _context = context;
        }

        // GET: ASIGNACIONCOMPUTADORES
        public async Task<IActionResult> Index()
        {
            return View(await _context.asignacionComputadores.ToListAsync());
        }

        // GET: ASIGNACIONCOMPUTADORES/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aSIGNACIONCOMPUTADORES = await _context.asignacionComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (aSIGNACIONCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(aSIGNACIONCOMPUTADORES);
        }

        // GET: ASIGNACIONCOMPUTADORES/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ASIGNACIONCOMPUTADORES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,RESPONSABLE,CODIGOINTERNO,TIEMPOINICIO,TIEMPOFIN")] ASIGNACIONCOMPUTADORES aSIGNACIONCOMPUTADORES)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aSIGNACIONCOMPUTADORES);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aSIGNACIONCOMPUTADORES);
        }

        // GET: ASIGNACIONCOMPUTADORES/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aSIGNACIONCOMPUTADORES = await _context.asignacionComputadores.FindAsync(id);
            if (aSIGNACIONCOMPUTADORES == null)
            {
                return NotFound();
            }
            return View(aSIGNACIONCOMPUTADORES);
        }

        // POST: ASIGNACIONCOMPUTADORES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,RESPONSABLE,CODIGOINTERNO,TIEMPOINICIO,TIEMPOFIN")] ASIGNACIONCOMPUTADORES aSIGNACIONCOMPUTADORES)
        {
            if (id != aSIGNACIONCOMPUTADORES.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aSIGNACIONCOMPUTADORES);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ASIGNACIONCOMPUTADORESExists(aSIGNACIONCOMPUTADORES.SECUENCIAL))
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
            return View(aSIGNACIONCOMPUTADORES);
        }

        // GET: ASIGNACIONCOMPUTADORES/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aSIGNACIONCOMPUTADORES = await _context.asignacionComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (aSIGNACIONCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(aSIGNACIONCOMPUTADORES);
        }

        // POST: ASIGNACIONCOMPUTADORES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aSIGNACIONCOMPUTADORES = await _context.asignacionComputadores.FindAsync(id);
            _context.asignacionComputadores.Remove(aSIGNACIONCOMPUTADORES);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ASIGNACIONCOMPUTADORESExists(int id)
        {
            return _context.asignacionComputadores.Any(e => e.SECUENCIAL == id);
        }
    }
}
