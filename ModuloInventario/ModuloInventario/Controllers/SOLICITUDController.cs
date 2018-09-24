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
    public class SOLICITUDController : Controller
    {
        private readonly InventarioContext _context;

        public SOLICITUDController(InventarioContext context)
        {
            _context = context;
        }

        // GET: SOLICITUD
        public async Task<IActionResult> Index()
        {
            return View(await _context.solicitud.ToListAsync());
        }

        // GET: SOLICITUD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sOLICITUD = await _context.solicitud
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (sOLICITUD == null)
            {
                return NotFound();
            }

            return View(sOLICITUD);
        }

        // GET: SOLICITUD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SOLICITUD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,SECUENCIALPERSONA,TIEMPO,TIPO,TIEMPOINICIO,TIEMPOFIN,DETALLE,ESTADO")] SOLICITUD sOLICITUD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sOLICITUD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sOLICITUD);
        }

        // GET: SOLICITUD/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sOLICITUD = await _context.solicitud.FindAsync(id);
            if (sOLICITUD == null)
            {
                return NotFound();
            }
            return View(sOLICITUD);
        }

        // POST: SOLICITUD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,SECUENCIALPERSONA,TIEMPO,TIPO,TIEMPOINICIO,TIEMPOFIN,DETALLE,ESTADO")] SOLICITUD sOLICITUD)
        {
            if (id != sOLICITUD.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sOLICITUD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SOLICITUDExists(sOLICITUD.SECUENCIAL))
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
            return View(sOLICITUD);
        }

        // GET: SOLICITUD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sOLICITUD = await _context.solicitud
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (sOLICITUD == null)
            {
                return NotFound();
            }

            return View(sOLICITUD);
        }

        // POST: SOLICITUD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sOLICITUD = await _context.solicitud.FindAsync(id);
            _context.solicitud.Remove(sOLICITUD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SOLICITUDExists(int id)
        {
            return _context.solicitud.Any(e => e.SECUENCIAL == id);
        }
    }
}
