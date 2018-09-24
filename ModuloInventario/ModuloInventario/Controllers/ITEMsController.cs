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
    public class ITEMsController : Controller
    {
        private readonly InventarioContext _context;

        public ITEMsController(InventarioContext context)
        {
            _context = context;
        }

        // GET: ITEMs
        public async Task<IActionResult> Index()
        {
            return View(await _context.item.ToListAsync());
        }

        // GET: ITEMs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTEM = await _context.item
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (iTEM == null)
            {
                return NotFound();
            }

            return View(iTEM);
        }

        // GET: ITEMs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ITEMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SECUENCIAL,CODIGO,TIPOITEM,CATEGORIAITEM")] ITEM iTEM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iTEM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iTEM);
        }

        // GET: ITEMs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTEM = await _context.item.FindAsync(id);
            if (iTEM == null)
            {
                return NotFound();
            }
            return View(iTEM);
        }

        // POST: ITEMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SECUENCIAL,CODIGO,TIPOITEM,CATEGORIAITEM")] ITEM iTEM)
        {
            if (id != iTEM.SECUENCIAL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iTEM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ITEMExists(iTEM.SECUENCIAL))
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
            return View(iTEM);
        }

        // GET: ITEMs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTEM = await _context.item
                .FirstOrDefaultAsync(m => m.SECUENCIAL == id);
            if (iTEM == null)
            {
                return NotFound();
            }

            return View(iTEM);
        }

        // POST: ITEMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iTEM = await _context.item.FindAsync(id);
            _context.item.Remove(iTEM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ITEMExists(int id)
        {
            return _context.item.Any(e => e.SECUENCIAL == id);
        }
    }
}
