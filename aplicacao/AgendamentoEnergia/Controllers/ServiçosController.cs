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
    public class ServiçosController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Serviços
        public ActionResult Index()
        {
            return View(db.Serviços.ToList());
        }

        // GET: Serviços/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serviço serviço = db.Serviços.Find(id);
            if (serviço == null)
            {
                return HttpNotFound();
            }
            return View(serviço);
        }

        // GET: Serviços/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Serviços/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiçoID,Descrição,Valor,Duração")] Serviço serviço)
        {
            if (ModelState.IsValid)
            {
                db.Serviços.Add(serviço);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviço);
        }

        // GET: Serviços/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serviço serviço = db.Serviços.Find(id);
            if (serviço == null)
            {
                return HttpNotFound();
            }
            return View(serviço);
        }

        // POST: Serviços/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiçoID,Descrição,Valor,Duração")] Serviço serviço)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviço).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviço);
        }

        // GET: Serviços/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serviço serviço = db.Serviços.Find(id);
            if (serviço == null)
            {
                return HttpNotFound();
            }
            return View(serviço);
        }

        // POST: Serviços/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Serviço serviço = db.Serviços.Find(id);
            db.Serviços.Remove(serviço);
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
