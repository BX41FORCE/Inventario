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
    public class ingresoComputadoresController : Controller
    {
        private Model1 db = new Model1();

        // GET: ingresoComputadores
        public ActionResult Index()
        {
            return View(db.ingresoComputadores.ToList());
        }

        // GET: ingresoComputadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingresoComputadores ingresoComputadores = db.ingresoComputadores.Find(id);
            if (ingresoComputadores == null)
            {
                return HttpNotFound();
            }
            return View(ingresoComputadores);
        }

        // GET: ingresoComputadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ingresoComputadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,DESCRIPCION,MEMORIARAM,PROCESADOR,DISCODURO,LICENCIADO,OFFICE,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] ingresoComputadores ingresoComputadores)
        {
            if (ModelState.IsValid)
            {
                db.ingresoComputadores.Add(ingresoComputadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingresoComputadores);
        }

        // GET: ingresoComputadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingresoComputadores ingresoComputadores = db.ingresoComputadores.Find(id);
            if (ingresoComputadores == null)
            {
                return HttpNotFound();
            }
            return View(ingresoComputadores);
        }

        // POST: ingresoComputadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,DESCRIPCION,MEMORIARAM,PROCESADOR,DISCODURO,LICENCIADO,OFFICE,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] ingresoComputadores ingresoComputadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingresoComputadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingresoComputadores);
        }

        // GET: ingresoComputadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingresoComputadores ingresoComputadores = db.ingresoComputadores.Find(id);
            if (ingresoComputadores == null)
            {
                return HttpNotFound();
            }
            return View(ingresoComputadores);
        }

        // POST: ingresoComputadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ingresoComputadores ingresoComputadores = db.ingresoComputadores.Find(id);
            db.ingresoComputadores.Remove(ingresoComputadores);
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
