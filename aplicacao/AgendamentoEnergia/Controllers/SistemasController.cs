using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AgendamentoEnergia.DAL;
using AgendamentoEnergia.Models;

namespace AgendamentoEnergia.Controllers
{
    public class SistemasController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Sistemas
        public ActionResult Index()
        {
            var sistemas = db.Sistemas.Include(s => s.Usuario);
            return View(sistemas.ToList());
        }

        // GET: Sistemas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sistema sistema = db.Sistemas.Find(id);
            if (sistema == null)
            {
                return HttpNotFound();
            }
            return View(sistema);
        }

        // GET: Sistemas/Create
        public ActionResult Create()
        {
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome");
            return View();
        }

        // POST: Sistemas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SistemaID,Nome,Potencia,dataInstalação,UsuarioID")] Sistema sistema)
        {
            if (ModelState.IsValid)
            {
                db.Sistemas.Add(sistema);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome", sistema.UsuarioID);
            return View(sistema);
        }

        // GET: Sistemas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sistema sistema = db.Sistemas.Find(id);
            if (sistema == null)
            {
                return HttpNotFound();
            }
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome", sistema.UsuarioID);
            return View(sistema);
        }

        // POST: Sistemas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SistemaID,Nome,Potencia,dataInstalação,UsuarioID")] Sistema sistema)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sistema).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome", sistema.UsuarioID);
            return View(sistema);
        }

        // GET: Sistemas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sistema sistema = db.Sistemas.Find(id);
            if (sistema == null)
            {
                return HttpNotFound();
            }
            return View(sistema);
        }

        // POST: Sistemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sistema sistema = db.Sistemas.Find(id);
            db.Sistemas.Remove(sistema);
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
