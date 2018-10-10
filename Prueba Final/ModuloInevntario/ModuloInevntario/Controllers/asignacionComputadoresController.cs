using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModuloInevntario.Models;

namespace ModuloInevntario.Controllers
{
    public class asignacionComputadoresController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: asignacionComputadores
        public ActionResult Index()
        {
            return View(db.asignacionComputadores.ToList());
        }

        // GET: asignacionComputadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionComputadores asignacionComputadores = db.asignacionComputadores.Find(id);
            if (asignacionComputadores == null)
            {
                return HttpNotFound();
            }
            return View(asignacionComputadores);
        }

        // GET: asignacionComputadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asignacionComputadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,RESPONSABLE,CODIGOINTERNO,TIEMPOINICIO,TIEMPOFIN")] asignacionComputadores asignacionComputadores)
        {
            if (ModelState.IsValid)
            {
                db.asignacionComputadores.Add(asignacionComputadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asignacionComputadores);
        }

        // GET: asignacionComputadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionComputadores asignacionComputadores = db.asignacionComputadores.Find(id);
            if (asignacionComputadores == null)
            {
                return HttpNotFound();
            }
            return View(asignacionComputadores);
        }

        // POST: asignacionComputadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,RESPONSABLE,CODIGOINTERNO,TIEMPOINICIO,TIEMPOFIN")] asignacionComputadores asignacionComputadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asignacionComputadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asignacionComputadores);
        }

        // GET: asignacionComputadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionComputadores asignacionComputadores = db.asignacionComputadores.Find(id);
            if (asignacionComputadores == null)
            {
                return HttpNotFound();
            }
            return View(asignacionComputadores);
        }

        // POST: asignacionComputadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asignacionComputadores asignacionComputadores = db.asignacionComputadores.Find(id);
            db.asignacionComputadores.Remove(asignacionComputadores);
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
