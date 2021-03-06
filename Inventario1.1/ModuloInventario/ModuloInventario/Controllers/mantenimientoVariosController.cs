﻿using System;
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
    public class mantenimientoVariosController : Controller
    {
        private Model1 db = new Model1();

        // GET: mantenimientoVarios
        public ActionResult Index()
        {
            return View(db.mantenimientoVarios.ToList());
        }

        // GET: mantenimientoVarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mantenimientoVarios mantenimientoVarios = db.mantenimientoVarios.Find(id);
            if (mantenimientoVarios == null)
            {
                return HttpNotFound();
            }
            return View(mantenimientoVarios);
        }

        // GET: mantenimientoVarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mantenimientoVarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] mantenimientoVarios mantenimientoVarios)
        {
            if (ModelState.IsValid)
            {
                db.mantenimientoVarios.Add(mantenimientoVarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mantenimientoVarios);
        }

        // GET: mantenimientoVarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mantenimientoVarios mantenimientoVarios = db.mantenimientoVarios.Find(id);
            if (mantenimientoVarios == null)
            {
                return HttpNotFound();
            }
            return View(mantenimientoVarios);
        }

        // POST: mantenimientoVarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,TIPO,RESPONSABLE,CODIGOINTERNO")] mantenimientoVarios mantenimientoVarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mantenimientoVarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mantenimientoVarios);
        }

        // GET: mantenimientoVarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mantenimientoVarios mantenimientoVarios = db.mantenimientoVarios.Find(id);
            if (mantenimientoVarios == null)
            {
                return HttpNotFound();
            }
            return View(mantenimientoVarios);
        }

        // POST: mantenimientoVarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mantenimientoVarios mantenimientoVarios = db.mantenimientoVarios.Find(id);
            db.mantenimientoVarios.Remove(mantenimientoVarios);
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
