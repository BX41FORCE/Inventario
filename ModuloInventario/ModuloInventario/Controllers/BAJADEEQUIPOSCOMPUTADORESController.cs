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
    public class BAJADEEQUIPOSCOMPUTADORESController : Controller
    {
        private readonly InventarioContext _context;

        public BAJADEEQUIPOSCOMPUTADORESController(InventarioContext context)
        {
            _context = context;
        }

        // GET: BAJADEEQUIPOSCOMPUTADORES
        public async Task<IActionResult> Index()
        {
            return View(await _context.bajaComputadores.ToListAsync());
        }

        // GET: BAJADEEQUIPOSCOMPUTADORES/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAJADEEQUIPOSCOMPUTADORES = await _context.bajaComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (bAJADEEQUIPOSCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(bAJADEEQUIPOSCOMPUTADORES);
        }

        // GET: BAJADEEQUIPOSCOMPUTADORES/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BAJADEEQUIPOSCOMPUTADORES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] BAJADEEQUIPOSCOMPUTADORES bAJADEEQUIPOSCOMPUTADORES)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bAJADEEQUIPOSCOMPUTADORES);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bAJADEEQUIPOSCOMPUTADORES);
        }

        // GET: BAJADEEQUIPOSCOMPUTADORES/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAJADEEQUIPOSCOMPUTADORES = await _context.bajaComputadores.FindAsync(id);
            if (bAJADEEQUIPOSCOMPUTADORES == null)
            {
                return NotFound();
            }
            return View(bAJADEEQUIPOSCOMPUTADORES);
        }

        // POST: BAJADEEQUIPOSCOMPUTADORES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] BAJADEEQUIPOSCOMPUTADORES bAJADEEQUIPOSCOMPUTADORES)
        {
            if (id != bAJADEEQUIPOSCOMPUTADORES.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bAJADEEQUIPOSCOMPUTADORES);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BAJADEEQUIPOSCOMPUTADORESExists(bAJADEEQUIPOSCOMPUTADORES.SECUENCIAL))
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
            return View(bAJADEEQUIPOSCOMPUTADORES);
        }

        // GET: BAJADEEQUIPOSCOMPUTADORES/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAJADEEQUIPOSCOMPUTADORES = await _context.bajaComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (bAJADEEQUIPOSCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(bAJADEEQUIPOSCOMPUTADORES);
        }

        // POST: BAJADEEQUIPOSCOMPUTADORES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bAJADEEQUIPOSCOMPUTADORES = await _context.bajaComputadores.FindAsync(id);
            _context.bajaComputadores.Remove(bAJADEEQUIPOSCOMPUTADORES);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BAJADEEQUIPOSCOMPUTADORESExists(int id)
        {
            return _context.bajaComputadores.Any(e => e.SECUENCIAL == id);
        }
    }
}
