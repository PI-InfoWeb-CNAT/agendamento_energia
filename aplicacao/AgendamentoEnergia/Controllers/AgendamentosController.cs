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
    public class AgendamentosController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Agendamentos
        public ActionResult Index()
        {
            var agendamentoes = db.Agendamentoes.Include(a => a.Serviço).Include(a => a.Usuario);
            return View(agendamentoes.ToList());
        }

        // GET: Agendamentos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agendamento agendamento = db.Agendamentoes.Find(id);
            if (agendamento == null)
            {
                return HttpNotFound();
            }
            return View(agendamento);
        }

        // GET: Agendamentos/Create
        public ActionResult Create()
        {
            ViewBag.ServiçoID = new SelectList(db.Serviços, "ServiçoID", "Descrição");
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome");
            return View();
        }

        // POST: Agendamentos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgendamentoID,dataExecucao,dataCriacao,dataAgendamento,Descricao,Executado,BemSucedido,Confirmado,UsuarioID,ServiçoID")] Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                db.Agendamentoes.Add(agendamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ServiçoID = new SelectList(db.Serviços, "ServiçoID", "Descrição", agendamento.ServiçoID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome", agendamento.UsuarioID);
            return View(agendamento);
        }

        // GET: Agendamentos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agendamento agendamento = db.Agendamentoes.Find(id);
            if (agendamento == null)
            {
                return HttpNotFound();
            }
            ViewBag.ServiçoID = new SelectList(db.Serviços, "ServiçoID", "Descrição", agendamento.ServiçoID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome", agendamento.UsuarioID);
            return View(agendamento);
        }

        // POST: Agendamentos/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgendamentoID,dataExecucao,dataCriacao,dataAgendamento,Descricao,Executado,BemSucedido,Confirmado,UsuarioID,ServiçoID")] Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agendamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ServiçoID = new SelectList(db.Serviços, "ServiçoID", "Descrição", agendamento.ServiçoID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "Nome", agendamento.UsuarioID);
            return View(agendamento);
        }

        // GET: Agendamentos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agendamento agendamento = db.Agendamentoes.Find(id);
            if (agendamento == null)
            {
                return HttpNotFound();
            }
            return View(agendamento);
        }

        // POST: Agendamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Agendamento agendamento = db.Agendamentoes.Find(id);
            db.Agendamentoes.Remove(agendamento);
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
