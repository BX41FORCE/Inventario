using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModuloInventario.Models;

namespace ModuloInventario.Controllers
{
    public class bajaComputadoresController : Controller
    {
        private Model1 db = new Model1();

        // GET: bajaComputadores
        public ActionResult Index()
        {
            return View(db.bajaComputadores.ToList());
        }

        // GET: bajaComputadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bajaComputadores bajaComputadores = db.bajaComputadores.Find(id);
            if (bajaComputadores == null)
            {
                return HttpNotFound();
            }
            return View(bajaComputadores);
        }

        // GET: bajaComputadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bajaComputadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] bajaComputadores bajaComputadores)
        {
            if (ModelState.IsValid)
            {
                db.bajaComputadores.Add(bajaComputadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bajaComputadores);
        }

        // GET: bajaComputadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bajaComputadores bajaComputadores = db.bajaComputadores.Find(id);
            if (bajaComputadores == null)
            {
                return HttpNotFound();
            }
            return View(bajaComputadores);
        }

        // POST: bajaComputadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] bajaComputadores bajaComputadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bajaComputadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bajaComputadores);
        }

        // GET: bajaComputadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bajaComputadores bajaComputadores = db.bajaComputadores.Find(id);
            if (bajaComputadores == null)
            {
                return HttpNotFound();
            }
            return View(bajaComputadores);
        }

        // POST: bajaComputadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bajaComputadores bajaComputadores = db.bajaComputadores.Find(id);
            db.bajaComputadores.Remove(bajaComputadores);
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
