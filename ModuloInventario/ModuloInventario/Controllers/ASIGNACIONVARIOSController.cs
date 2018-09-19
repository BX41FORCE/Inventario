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
    public class ASIGNACIONVARIOSController : Controller
    {
        private readonly InventarioContext _context;

        public ASIGNACIONVARIOSController(InventarioContext context)
        {
            _context = context;
        }

        // GET: ASIGNACIONVARIOS
        public async Task<IActionResult> Index()
        {
            return View(await _context.asignacionVarios.ToListAsync());
        }

        // GET: ASIGNACIONVARIOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aSIGNACIONVARIOS = await _context.asignacionVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (aSIGNACIONVARIOS == null)
            {
                return NotFound();
            }

            return View(aSIGNACIONVARIOS);
        }

        // GET: ASIGNACIONVARIOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ASIGNACIONVARIOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,RESPONSABLE,SECUANCIALPERSONA,SECUANCIALINGRESOVARIOS,TIEMPOINICIO,TIEMPOFIN")] ASIGNACIONVARIOS aSIGNACIONVARIOS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aSIGNACIONVARIOS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aSIGNACIONVARIOS);
        }

        // GET: ASIGNACIONVARIOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aSIGNACIONVARIOS = await _context.asignacionVarios.FindAsync(id);
            if (aSIGNACIONVARIOS == null)
            {
                return NotFound();
            }
            return View(aSIGNACIONVARIOS);
        }

        // POST: ASIGNACIONVARIOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,RESPONSABLE,SECUANCIALPERSONA,SECUANCIALINGRESOVARIOS,TIEMPOINICIO,TIEMPOFIN")] ASIGNACIONVARIOS aSIGNACIONVARIOS)
        {
            if (id != aSIGNACIONVARIOS.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aSIGNACIONVARIOS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ASIGNACIONVARIOSExists(aSIGNACIONVARIOS.SECUENCIAL))
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
            return View(aSIGNACIONVARIOS);
        }

        // GET: ASIGNACIONVARIOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aSIGNACIONVARIOS = await _context.asignacionVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (aSIGNACIONVARIOS == null)
            {
                return NotFound();
            }

            return View(aSIGNACIONVARIOS);
        }

        // POST: ASIGNACIONVARIOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aSIGNACIONVARIOS = await _context.asignacionVarios.FindAsync(id);
            _context.asignacionVarios.Remove(aSIGNACIONVARIOS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ASIGNACIONVARIOSExists(int id)
        {
            return _context.asignacionVarios.Any(e => e.SECUENCIAL == id);
        }
    }
}
