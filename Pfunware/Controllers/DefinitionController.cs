using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pfunware.Models;

namespace Pfunware.Controllers
{
    public class DefinitionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Definition/
        public ActionResult Index()
        {
            return View(db.DefinitionViewModels.ToList());
        }

        // GET: /Definition/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DefinitionViewModel definitionviewmodel = db.DefinitionViewModels.Find(id);
            if (definitionviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(definitionviewmodel);
        }

        // GET: /Definition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Definition/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="DefinitionId,Order,Category,Technology,Word,Definition")] DefinitionViewModel definitionviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.DefinitionViewModels.Add(definitionviewmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(definitionviewmodel);
        }

        // GET: /Definition/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DefinitionViewModel definitionviewmodel = db.DefinitionViewModels.Find(id);
            if (definitionviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(definitionviewmodel);
        }

        // POST: /Definition/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="DefinitionId,Order,Category,Technology,Word,Definition")] DefinitionViewModel definitionviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(definitionviewmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(definitionviewmodel);
        }

        // GET: /Definition/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DefinitionViewModel definitionviewmodel = db.DefinitionViewModels.Find(id);
            if (definitionviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(definitionviewmodel);
        }

        // POST: /Definition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DefinitionViewModel definitionviewmodel = db.DefinitionViewModels.Find(id);
            db.DefinitionViewModels.Remove(definitionviewmodel);
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
