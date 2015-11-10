using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NSPecor.Models;

namespace NSPecor.Controllers
{
    public class TIpoCPController : Controller
    {
        private pcUpmeCnx db = new pcUpmeCnx();

        // GET: /TIpoCP/
        public ActionResult Index()
        {
            return View(db.MUB_TIPO_CP.ToList());
        }

        // GET: /TIpoCP/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUB_TIPO_CP mub_tipo_cp = db.MUB_TIPO_CP.Find(id);
            if (mub_tipo_cp == null)
            {
                return HttpNotFound();
            }
            return View(mub_tipo_cp);
        }

        // GET: /TIpoCP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TIpoCP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID_TIPO_CP,NOM_TIPO_CP,ABR_TIPO_CP,ID_USUARIO_ACTUALIZACION,FECHA_ACTUALIZACION")] MUB_TIPO_CP mub_tipo_cp)
        {
            if (ModelState.IsValid)
            {
                db.MUB_TIPO_CP.Add(mub_tipo_cp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mub_tipo_cp);
        }

        // GET: /TIpoCP/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUB_TIPO_CP mub_tipo_cp = db.MUB_TIPO_CP.Find(id);
            if (mub_tipo_cp == null)
            {
                return HttpNotFound();
            }
            return View(mub_tipo_cp);
        }

        // POST: /TIpoCP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID_TIPO_CP,NOM_TIPO_CP,ABR_TIPO_CP,ID_USUARIO_ACTUALIZACION,FECHA_ACTUALIZACION")] MUB_TIPO_CP mub_tipo_cp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mub_tipo_cp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mub_tipo_cp);
        }

        // GET: /TIpoCP/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUB_TIPO_CP mub_tipo_cp = db.MUB_TIPO_CP.Find(id);
            if (mub_tipo_cp == null)
            {
                return HttpNotFound();
            }
            return View(mub_tipo_cp);
        }

        // POST: /TIpoCP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            MUB_TIPO_CP mub_tipo_cp = db.MUB_TIPO_CP.Find(id);
            db.MUB_TIPO_CP.Remove(mub_tipo_cp);
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
