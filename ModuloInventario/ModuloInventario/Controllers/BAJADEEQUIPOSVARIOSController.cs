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
    public class BAJADEEQUIPOSVARIOSController : Controller
    {
        private readonly InventarioContext _context;

        public BAJADEEQUIPOSVARIOSController(InventarioContext context)
        {
            _context = context;
        }

        // GET: BAJADEEQUIPOSVARIOS
        public async Task<IActionResult> Index()
        {
            return View(await _context.bajaVarios.ToListAsync());
        }

        // GET: BAJADEEQUIPOSVARIOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAJADEEQUIPOSVARIOS = await _context.bajaVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (bAJADEEQUIPOSVARIOS == null)
            {
                return NotFound();
            }

            return View(bAJADEEQUIPOSVARIOS);
        }

        // GET: BAJADEEQUIPOSVARIOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BAJADEEQUIPOSVARIOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,TIPO,SECUANCIALPERSONA,SECUANCIALINGRESOVARIOS")] BAJADEEQUIPOSVARIOS bAJADEEQUIPOSVARIOS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bAJADEEQUIPOSVARIOS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bAJADEEQUIPOSVARIOS);
        }

        // GET: BAJADEEQUIPOSVARIOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAJADEEQUIPOSVARIOS = await _context.bajaVarios.FindAsync(id);
            if (bAJADEEQUIPOSVARIOS == null)
            {
                return NotFound();
            }
            return View(bAJADEEQUIPOSVARIOS);
        }

        // POST: BAJADEEQUIPOSVARIOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,TIPO,SECUANCIALPERSONA,SECUANCIALINGRESOVARIOS")] BAJADEEQUIPOSVARIOS bAJADEEQUIPOSVARIOS)
        {
            if (id != bAJADEEQUIPOSVARIOS.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bAJADEEQUIPOSVARIOS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BAJADEEQUIPOSVARIOSExists(bAJADEEQUIPOSVARIOS.SECUENCIAL))
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
            return View(bAJADEEQUIPOSVARIOS);
        }

        // GET: BAJADEEQUIPOSVARIOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAJADEEQUIPOSVARIOS = await _context.bajaVarios
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (bAJADEEQUIPOSVARIOS == null)
            {
                return NotFound();
            }

            return View(bAJADEEQUIPOSVARIOS);
        }

        // POST: BAJADEEQUIPOSVARIOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bAJADEEQUIPOSVARIOS = await _context.bajaVarios.FindAsync(id);
            _context.bajaVarios.Remove(bAJADEEQUIPOSVARIOS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BAJADEEQUIPOSVARIOSExists(int id)
        {
            return _context.bajaVarios.Any(e => e.SECUENCIAL == id);
        }
    }
}
