using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModuloInevntario.Models;
using ModuloInevntario.ViewModels;

namespace ModuloInevntario.Controllers
{
    public class mantenimientoComputadoresController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: mantenimientoComputadores
        public ActionResult Index(int pagina = 1)
        {
            var cantidadRegistrosPorPagina = 10; // parámetro
            using (var db = new InventarioContext())
            {

                var MatenimientoComputador = db.mantenimientoComputadores.OrderBy(x => x.SECUENCIAL)
                    .Skip((pagina - 1) * cantidadRegistrosPorPagina)
                    .Take(cantidadRegistrosPorPagina).ToList();
                var totalDeRegistros = db.mantenimientoComputadores.Count();

                var modelo = new IndexViewModel();
                modelo.matenimientoComputador = MatenimientoComputador;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistros;
                modelo.RegistrosPorPagina = cantidadRegistrosPorPagina;

                return View(modelo);
            }
            //return View(db.mantenimientoComputadores.ToList());
        }

        // GET: mantenimientoComputadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mantenimientoComputadores mantenimientoComputadores = db.mantenimientoComputadores.Find(id);
            if (mantenimientoComputadores == null)
            {
                return HttpNotFound();
            }
            return View(mantenimientoComputadores);
        }

        // GET: mantenimientoComputadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mantenimientoComputadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] mantenimientoComputadores mantenimientoComputadores)
        {
            if (ModelState.IsValid)
            {
                db.mantenimientoComputadores.Add(mantenimientoComputadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mantenimientoComputadores);
        }

        // GET: mantenimientoComputadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mantenimientoComputadores mantenimientoComputadores = db.mantenimientoComputadores.Find(id);
            if (mantenimientoComputadores == null)
            {
                return HttpNotFound();
            }
            return View(mantenimientoComputadores);
        }

        // POST: mantenimientoComputadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] mantenimientoComputadores mantenimientoComputadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mantenimientoComputadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mantenimientoComputadores);
        }

        // GET: mantenimientoComputadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mantenimientoComputadores mantenimientoComputadores = db.mantenimientoComputadores.Find(id);
            if (mantenimientoComputadores == null)
            {
                return HttpNotFound();
            }
            return View(mantenimientoComputadores);
        }

        // POST: mantenimientoComputadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mantenimientoComputadores mantenimientoComputadores = db.mantenimientoComputadores.Find(id);
            db.mantenimientoComputadores.Remove(mantenimientoComputadores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
