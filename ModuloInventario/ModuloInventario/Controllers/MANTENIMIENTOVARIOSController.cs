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
    public class MANTENIMIENTOVARIOSController : Controller
    {
        private readonly InventarioContext _context;

        public MANTENIMIENTOVARIOSController(InventarioContext context)
        {
            _context = context;
        }

        // GET: MANTENIMIENTOVARIOS
        public async Task<IActionResult> Index()
        {
            return View(await _context.mantenimientoVarios.ToListAsync());
        }

        // GET: MANTENIMIENTOVARIOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mANTENIMIENTOVARIOS = await _context.mantenimientoVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (mANTENIMIENTOVARIOS == null)
            {
                return NotFound();
            }

            return View(mANTENIMIENTOVARIOS);
        }

        // GET: MANTENIMIENTOVARIOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MANTENIMIENTOVARIOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,TIPO,SECUANCIALPERSONA,SECUANCIALINGRESOVARIOS")] MANTENIMIENTOVARIOS mANTENIMIENTOVARIOS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mANTENIMIENTOVARIOS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mANTENIMIENTOVARIOS);
        }

        // GET: MANTENIMIENTOVARIOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mANTENIMIENTOVARIOS = await _context.mantenimientoVarios.FindAsync(id);
            if (mANTENIMIENTOVARIOS == null)
            {
                return NotFound();
            }
            return View(mANTENIMIENTOVARIOS);
        }

        // POST: MANTENIMIENTOVARIOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,TIPO,SECUANCIALPERSONA,SECUANCIALINGRESOVARIOS")] MANTENIMIENTOVARIOS mANTENIMIENTOVARIOS)
        {
            if (id != mANTENIMIENTOVARIOS.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mANTENIMIENTOVARIOS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MANTENIMIENTOVARIOSExists(mANTENIMIENTOVARIOS.SECUENCIAL))
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
            return View(mANTENIMIENTOVARIOS);
        }

        // GET: MANTENIMIENTOVARIOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mANTENIMIENTOVARIOS = await _context.mantenimientoVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (mANTENIMIENTOVARIOS == null)
            {
                return NotFound();
            }

            return View(mANTENIMIENTOVARIOS);
        }

        // POST: MANTENIMIENTOVARIOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mANTENIMIENTOVARIOS = await _context.mantenimientoVarios.FindAsync(id);
            _context.mantenimientoVarios.Remove(mANTENIMIENTOVARIOS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MANTENIMIENTOVARIOSExists(int id)
        {
            return _context.mantenimientoVarios.Any(e => e.SECUENCIAL == id);
        }
    }
}
