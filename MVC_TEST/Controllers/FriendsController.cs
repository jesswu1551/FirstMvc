using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_TEST.Models;

namespace MVC_TEST.Controllers
{
    public class FriendsController : Controller
    {
        private FriendsContext db = new FriendsContext();

        // GET: Friends
        public ActionResult Index()
        {
            return View(db.FriendsModels.ToList());
        }

        // GET: Friends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendsModel friendsModel = db.FriendsModels.Find(id);
            if (friendsModel == null)
            {
                return HttpNotFound();
            }
            return View(friendsModel);
        }

        // GET: Friends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friends/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Email,City")] FriendsModel friendsModel)
        {
            if (ModelState.IsValid)
            {
                db.FriendsModels.Add(friendsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(friendsModel);
        }

        // GET: Friends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendsModel friendsModel = db.FriendsModels.Find(id);
            if (friendsModel == null)
            {
                return HttpNotFound();
            }
            return View(friendsModel);
        }

        // POST: Friends/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email,City")] FriendsModel friendsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friendsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(friendsModel);
        }

        // GET: Friends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendsModel friendsModel = db.FriendsModels.Find(id);
            if (friendsModel == null)
            {
                return HttpNotFound();
            }
            return View(friendsModel);
        }

        // POST: Friends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FriendsModel friendsModel = db.FriendsModels.Find(id);
            db.FriendsModels.Remove(friendsModel);
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
