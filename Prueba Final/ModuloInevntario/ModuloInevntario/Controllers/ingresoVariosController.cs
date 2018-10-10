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
    public class ingresoVariosController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: ingresoVarios
        public ActionResult Index(int pagina = 1)
        {
            var cantidadRegistrosPorPagina = 10; // parámetro
            using (var db = new InventarioContext())
            {

                var IngresoVario = db.ingresoVarios.OrderBy(x => x.SECUENCIAL)
                    .Skip((pagina - 1) * cantidadRegistrosPorPagina)
                    .Take(cantidadRegistrosPorPagina).ToList();
                var totalDeRegistros = db.ingresoVarios.Count();

                var modelo = new IndexViewModel();
                modelo.ingresoVario = IngresoVario;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistros;
                modelo.RegistrosPorPagina = cantidadRegistrosPorPagina;

                return View(modelo);
            }
            //return View(db.ingresoVarios.ToList());
        }

        // GET: ingresoVarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingresoVarios ingresoVarios = db.ingresoVarios.Find(id);
            if (ingresoVarios == null)
            {
                return HttpNotFound();
            }
            return View(ingresoVarios);
        }

        // GET: ingresoVarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ingresoVarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,DESCRIPCION,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] ingresoVarios ingresoVarios)
        {
            if (ModelState.IsValid)
            {
                db.ingresoVarios.Add(ingresoVarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingresoVarios);
        }

        // GET: ingresoVarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingresoVarios ingresoVarios = db.ingresoVarios.Find(id);
            if (ingresoVarios == null)
            {
                return HttpNotFound();
            }
            return View(ingresoVarios);
        }

        // POST: ingresoVarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECUENCIAL,CODIGOINTERNO,CUADADDEUBICACION,DESCRIPCION,MARCA,MODELO,SERIE,PARTICULARIDAD,ESTADO,NODEFACTURA,VALORFACTURA,FECHAADQUISICION,OBSERVACIONES")] ingresoVarios ingresoVarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingresoVarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingresoVarios);
        }

        // GET: ingresoVarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingresoVarios ingresoVarios = db.ingresoVarios.Find(id);
            if (ingresoVarios == null)
            {
                return HttpNotFound();
            }
            return View(ingresoVarios);
        }

        // POST: ingresoVarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ingresoVarios ingresoVarios = db.ingresoVarios.Find(id);
            db.ingresoVarios.Remove(ingresoVarios);
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
