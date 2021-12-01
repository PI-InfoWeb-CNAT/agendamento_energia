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
    public class EquipamentosController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Equipamentos
        public ActionResult Index()
        {
            return View(db.Equipamentos.ToList());
        }

        // GET: Equipamentos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamento equipamento = db.Equipamentos.Find(id);
            if (equipamento == null)
            {
                return HttpNotFound();
            }
            return View(equipamento);
        }

        // GET: Equipamentos/Create
        public ActionResult Create()
        {
            IList<SelectListItem> amimi = new List<SelectListItem>() { new SelectListItem { Text = "Action", Value = "0" }, new SelectListItem { Text = "Amimi", Value = "1" } };

            ViewBag.Peixe = new SelectList(amimi, "Value", "Text");
            return View();
        }

        // POST: Equipamentos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipamentoID,Tipo,DataSheet,Potencia,Detalhes")] Equipamento equipamento)
        {
            if (ModelState.IsValid)
            {
                db.Equipamentos.Add(equipamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipamento);
        }

        // GET: Equipamentos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamento equipamento = db.Equipamentos.Find(id);
            if (equipamento == null)
            {
                return HttpNotFound();
            }
            return View(equipamento);
        }

        // POST: Equipamentos/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipamentoID,Tipo,DataSheet,Potencia,Detalhes")] Equipamento equipamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipamento);
        }

        // GET: Equipamentos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamento equipamento = db.Equipamentos.Find(id);
            if (equipamento == null)
            {
                return HttpNotFound();
            }
            return View(equipamento);
        }

        // POST: Equipamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Equipamento equipamento = db.Equipamentos.Find(id);
            db.Equipamentos.Remove(equipamento);
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
