using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Memberdhips_1.Entities;
using Memberdhips_1.Models;

namespace Memberdhips_1.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserSubscriptionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/UserSubscription
        public async Task<ActionResult> Index()
        {
            return View(await db.UserSubscriptions.ToListAsync());
        }

        // GET: Admin/UserSubscription/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserSubscription userSubscription = await db.UserSubscriptions.FindAsync(id);
            if (userSubscription == null)
            {
                return HttpNotFound();
            }
            return View(userSubscription);
        }

        // GET: Admin/UserSubscription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/UserSubscription/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SubscriptionId,UserId,StartDate,EndDate")] UserSubscription userSubscription)
        {
            if (ModelState.IsValid)
            {
                db.UserSubscriptions.Add(userSubscription);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(userSubscription);
        }

        // GET: Admin/UserSubscription/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserSubscription userSubscription = await db.UserSubscriptions.FindAsync(id);
            if (userSubscription == null)
            {
                return HttpNotFound();
            }
            return View(userSubscription);
        }

        // POST: Admin/UserSubscription/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SubscriptionId,UserId,StartDate,EndDate")] UserSubscription userSubscription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userSubscription).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(userSubscription);
        }

        // GET: Admin/UserSubscription/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserSubscription userSubscription = await db.UserSubscriptions.FindAsync(id);
            if (userSubscription == null)
            {
                return HttpNotFound();
            }
            return View(userSubscription);
        }

        // POST: Admin/UserSubscription/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UserSubscription userSubscription = await db.UserSubscriptions.FindAsync(id);
            db.UserSubscriptions.Remove(userSubscription);
            await db.SaveChangesAsync();
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
