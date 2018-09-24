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
    public class MANTENIMIENTOCOMPUTADORESController : Controller
    {
        private readonly InventarioContext _context;

        public MANTENIMIENTOCOMPUTADORESController(InventarioContext context)
        {
            _context = context;
        }

        // GET: MANTENIMIENTOCOMPUTADORES
        public async Task<IActionResult> Index()
        {
            return View(await _context.mantenimientoComputadores.ToListAsync());
        }

        // GET: MANTENIMIENTOCOMPUTADORES/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mANTENIMIENTOCOMPUTADORES = await _context.mantenimientoComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (mANTENIMIENTOCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(mANTENIMIENTOCOMPUTADORES);
        }

        // GET: MANTENIMIENTOCOMPUTADORES/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MANTENIMIENTOCOMPUTADORES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,TIPO,SECUANCIALPERSONA,SECUANCIALINGRESOCOMPUTADORES")] MANTENIMIENTOCOMPUTADORES mANTENIMIENTOCOMPUTADORES)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mANTENIMIENTOCOMPUTADORES);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mANTENIMIENTOCOMPUTADORES);
        }

        // GET: MANTENIMIENTOCOMPUTADORES/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mANTENIMIENTOCOMPUTADORES = await _context.mantenimientoComputadores.FindAsync(id);
            if (mANTENIMIENTOCOMPUTADORES == null)
            {
                return NotFound();
            }
            return View(mANTENIMIENTOCOMPUTADORES);
        }

        // POST: MANTENIMIENTOCOMPUTADORES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,TIPO,SECUANCIALPERSONA,SECUANCIALINGRESOCOMPUTADORES")] MANTENIMIENTOCOMPUTADORES mANTENIMIENTOCOMPUTADORES)
        {
            if (id != mANTENIMIENTOCOMPUTADORES.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mANTENIMIENTOCOMPUTADORES);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MANTENIMIENTOCOMPUTADORESExists(mANTENIMIENTOCOMPUTADORES.SECUENCIAL))
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
            return View(mANTENIMIENTOCOMPUTADORES);
        }

        // GET: MANTENIMIENTOCOMPUTADORES/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mANTENIMIENTOCOMPUTADORES = await _context.mantenimientoComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (mANTENIMIENTOCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(mANTENIMIENTOCOMPUTADORES);
        }

        // POST: MANTENIMIENTOCOMPUTADORES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mANTENIMIENTOCOMPUTADORES = await _context.mantenimientoComputadores.FindAsync(id);
            _context.mantenimientoComputadores.Remove(mANTENIMIENTOCOMPUTADORES);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MANTENIMIENTOCOMPUTADORESExists(int id)
        {
            return _context.mantenimientoComputadores.Any(e => e.SECUENCIAL == id);
        }
    }
}
