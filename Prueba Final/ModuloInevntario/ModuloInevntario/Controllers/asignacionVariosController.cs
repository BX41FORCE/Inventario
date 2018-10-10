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
    public class asignacionVariosController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: asignacionVarios
        public ActionResult Index(int pagina = 1)
        {
            var cantidadRegistrosPorPagina = 10; // parámetro
            using (var db = new InventarioContext())
            {

                var AsignacionVario = db.asignacionVarios.OrderBy(x => x.SECUENCIAL)
                    .Skip((pagina - 1) * cantidadRegistrosPorPagina)
                    .Take(cantidadRegistrosPorPagina).ToList();
                var totalDeRegistros = db.asignacionVarios.Count();

                var modelo = new IndexViewModel();
                modelo.asignacionVario = AsignacionVario;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistros;
                modelo.RegistrosPorPagina = cantidadRegistrosPorPagina;

                return View(modelo);
            }
            //return View(db.asignacionVarios.ToList());
        }

        // GET: asignacionVarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionVarios asignacionVarios = db.asignacionVarios.Find(id);
            if (asignacionVarios == null)
            {
                return HttpNotFound();
            }
            return View(asignacionVarios);
        }

        // GET: asignacionVarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asignacionVarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,RESPONSABLE,CODIGOINTERNO,TIEMPOINICIO,TIEMPOFIN")] asignacionVarios asignacionVarios)
        {
            if (ModelState.IsValid)
            {
                db.asignacionVarios.Add(asignacionVarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asignacionVarios);
        }

        // GET: asignacionVarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionVarios asignacionVarios = db.asignacionVarios.Find(id);
            if (asignacionVarios == null)
            {
                return HttpNotFound();
            }
            return View(asignacionVarios);
        }

        // POST: asignacionVarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,RESPONSABLE,CODIGOINTERNO,TIEMPOINICIO,TIEMPOFIN")] asignacionVarios asignacionVarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asignacionVarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asignacionVarios);
        }

        // GET: asignacionVarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionVarios asignacionVarios = db.asignacionVarios.Find(id);
            if (asignacionVarios == null)
            {
                return HttpNotFound();
            }
            return View(asignacionVarios);
        }

        // POST: asignacionVarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asignacionVarios asignacionVarios = db.asignacionVarios.Find(id);
            db.asignacionVarios.Remove(asignacionVarios);
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
