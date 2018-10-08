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
    public class bajaVariosController : Controller
    {
        private Model1 db = new Model1();

        // GET: bajaVarios
        public ActionResult Index()
        {
            return View(db.bajaVarios.ToList());
        }

        // GET: bajaVarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bajaVarios bajaVarios = db.bajaVarios.Find(id);
            if (bajaVarios == null)
            {
                return HttpNotFound();
            }
            return View(bajaVarios);
        }

        // GET: bajaVarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bajaVarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] bajaVarios bajaVarios)
        {
            if (ModelState.IsValid)
            {
                db.bajaVarios.Add(bajaVarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bajaVarios);
        }

        // GET: bajaVarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bajaVarios bajaVarios = db.bajaVarios.Find(id);
            if (bajaVarios == null)
            {
                return HttpNotFound();
            }
            return View(bajaVarios);
        }

        // POST: bajaVarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] bajaVarios bajaVarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bajaVarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bajaVarios);
        }

        // GET: bajaVarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bajaVarios bajaVarios = db.bajaVarios.Find(id);
            if (bajaVarios == null)
            {
                return HttpNotFound();
            }
            return View(bajaVarios);
        }

        // POST: bajaVarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bajaVarios bajaVarios = db.bajaVarios.Find(id);
            db.bajaVarios.Remove(bajaVarios);
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
