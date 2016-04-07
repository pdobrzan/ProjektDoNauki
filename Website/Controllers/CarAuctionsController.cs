using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website.DataAccess.Models;

namespace Website.Controllers
{
    public class CarAuctionsController : Controller
    {
        private CarAuctionEntities db = new CarAuctionEntities();

        // GET: CarAuctions
        public ActionResult Index()
        {
            return View(db.Auctions.ToList());
        }

        // GET: CarAuctions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarAuction carAuction = db.Auctions.Find(id);
            if (carAuction == null)
            {
                return HttpNotFound();
            }
            return View(carAuction);
        }

        // GET: CarAuctions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarAuctions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AuctionNumber,Price,Power")] CarAuction carAuction)
        {
            if (ModelState.IsValid)
            {
                db.Auctions.Add(carAuction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carAuction);
        }

        // GET: CarAuctions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarAuction carAuction = db.Auctions.Find(id);
            if (carAuction == null)
            {
                return HttpNotFound();
            }
            return View(carAuction);
        }

        // POST: CarAuctions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AuctionNumber,Price,Power")] CarAuction carAuction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carAuction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carAuction);
        }

        // GET: CarAuctions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarAuction carAuction = db.Auctions.Find(id);
            if (carAuction == null)
            {
                return HttpNotFound();
            }
            return View(carAuction);
        }

        // POST: CarAuctions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarAuction carAuction = db.Auctions.Find(id);
            db.Auctions.Remove(carAuction);
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
