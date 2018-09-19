using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModuloInventario.DBContext;

namespace ModuloInventario.Controllers
{
    public class INGRESOVARIOSController : Controller
    {
        private readonly InventarioContext _context;

        public INGRESOVARIOSController(InventarioContext context)
        {
            _context = context;
        }

        // GET: INGRESOVARIOS
        public async Task<IActionResult> Index()
        {
            return View(await _context.ingresoVarios.ToListAsync());
        }

        // GET: INGRESOVARIOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNGRESOVARIOS = await _context.ingresoVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (iNGRESOVARIOS == null)
            {
                return NotFound();
            }

            return View(iNGRESOVARIOS);
        }

        // GET: INGRESOVARIOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: INGRESOVARIOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,SECUENCIALITEM,DESCRIPCION,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] INGRESOVARIOS iNGRESOVARIOS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iNGRESOVARIOS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iNGRESOVARIOS);
        }

        // GET: INGRESOVARIOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNGRESOVARIOS = await _context.ingresoVarios.FindAsync(id);
            if (iNGRESOVARIOS == null)
            {
                return NotFound();
            }
            return View(iNGRESOVARIOS);
        }

        // POST: INGRESOVARIOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,SECUENCIALITEM,DESCRIPCION,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] INGRESOVARIOS iNGRESOVARIOS)
        {
            if (id != iNGRESOVARIOS.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iNGRESOVARIOS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!INGRESOVARIOSExists(iNGRESOVARIOS.SECUENCIAL))
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
            return View(iNGRESOVARIOS);
        }

        // GET: INGRESOVARIOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNGRESOVARIOS = await _context.ingresoVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (iNGRESOVARIOS == null)
            {
                return NotFound();
            }

            return View(iNGRESOVARIOS);
        }

        // POST: INGRESOVARIOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iNGRESOVARIOS = await _context.ingresoVarios.FindAsync(id);
            _context.ingresoVarios.Remove(iNGRESOVARIOS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool INGRESOVARIOSExists(int id)
        {
            return _context.ingresoVarios.Any(e => e.SECUENCIAL == id);
        }
    }
}
