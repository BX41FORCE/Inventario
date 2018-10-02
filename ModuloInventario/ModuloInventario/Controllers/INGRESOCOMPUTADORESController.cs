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
    public class INGRESOCOMPUTADORESController : Controller
    {
        private readonly InventarioContext _context;

        public INGRESOCOMPUTADORESController(InventarioContext context)
        {
            _context = context;
        }

        // GET: INGRESOCOMPUTADORES
        public async Task<IActionResult> Index()
        {
            return View(await _context.ingresoComputadores.ToListAsync());
        }

        // GET: INGRESOCOMPUTADORES/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNGRESOCOMPUTADORES = await _context.ingresoComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (iNGRESOCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(iNGRESOCOMPUTADORES);
        }

        // GET: INGRESOCOMPUTADORES/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: INGRESOCOMPUTADORES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,ITEM,DESCRIPCION,MEMORIARAM,PROCESADOR,DISCODURO,SISTEMAOPERATIVO,LICENCIADO,OFFICE,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] INGRESOCOMPUTADORES iNGRESOCOMPUTADORES)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iNGRESOCOMPUTADORES);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iNGRESOCOMPUTADORES);
        }

        // GET: INGRESOCOMPUTADORES/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNGRESOCOMPUTADORES = await _context.ingresoComputadores.FindAsync(id);
            if (iNGRESOCOMPUTADORES == null)
            {
                return NotFound();
            }
            return View(iNGRESOCOMPUTADORES);
        }

        // POST: INGRESOCOMPUTADORES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,ITEM,DESCRIPCION,MEMORIARAM,PROCESADOR,DISCODURO,SISTEMAOPERATIVO,LICENCIADO,OFFICE,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] INGRESOCOMPUTADORES iNGRESOCOMPUTADORES)
        {
            if (id != iNGRESOCOMPUTADORES.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iNGRESOCOMPUTADORES);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!INGRESOCOMPUTADORESExists(iNGRESOCOMPUTADORES.SECUENCIAL))
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
            return View(iNGRESOCOMPUTADORES);
        }

        // GET: INGRESOCOMPUTADORES/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNGRESOCOMPUTADORES = await _context.ingresoComputadores
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (iNGRESOCOMPUTADORES == null)
            {
                return NotFound();
            }

            return View(iNGRESOCOMPUTADORES);
        }

        // POST: INGRESOCOMPUTADORES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iNGRESOCOMPUTADORES = await _context.ingresoComputadores.FindAsync(id);
            _context.ingresoComputadores.Remove(iNGRESOCOMPUTADORES);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool INGRESOCOMPUTADORESExists(int id)
        {
            return _context.ingresoComputadores.Any(e => e.SECUENCIAL == id);
        }
    }
}
