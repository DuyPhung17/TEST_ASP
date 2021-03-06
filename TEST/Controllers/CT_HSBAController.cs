﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TEST.Models;

namespace TEST.Controllers
{
    public class CT_HSBAController : Controller
    {
        private QLBNKMEntities db = new QLBNKMEntities();

        // GET: CT_HSBA

        public ActionResult Index(int? id)
        {
            var cT_HSBAs = db.CT_HSBA.Where(abc => abc.MAHSBA == id);
            int MABN = db.HSBAs.Find(id).MABN;
            ViewBag.TENBN = db.BENHNHANs.Find(MABN).TENBN;
            return View(cT_HSBAs.ToList());
        }

        public ActionResult ThongKe()
        {
            var hSBAs = db.CT_HSBA.Include(h => h.HSBA.BENHNHAN).Include(h => h.BACSI);
            ViewBag.tongbn = hSBAs.Count();
            TOATHUOC tt;
            int tong = 0;
            foreach (CT_HSBA hs in hSBAs)
            {
                tt = db.TOATHUOCs.Find(hs.MAHSBA);
                var listCTtoathuoc = db.CT_TOATHUOC.Where(m => m.MATOATHUOC == tt.MATOATHUOC);
                foreach (CT_TOATHUOC ct in listCTtoathuoc)
                {
                    tong += ct.THUOC.DONGIATHUOC * ct.SOLUONG;
                }
            }
            ViewBag.tongtien = tong;

            return View(hSBAs.ToList());
        }

        [HttpPost]
        public ActionResult ThongKe(DateTime TUNGAY , DateTime DENNGAY)
        {   
            var hSBAs = db.CT_HSBA.Where(abc => abc.NGAYKHAM.CompareTo(TUNGAY)>0 && abc.NGAYKHAM.CompareTo(DENNGAY)<0);
            ViewBag.tongbn = hSBAs.Count();
            TOATHUOC tt;
            int tong = 0;
            foreach (CT_HSBA hs in hSBAs)
            {
                tt = db.TOATHUOCs.Find(hs.MAHSBA);
                var listCTtoathuoc = db.CT_TOATHUOC.Where(m => m.MATOATHUOC == tt.MATOATHUOC);
                foreach (CT_TOATHUOC ct in listCTtoathuoc)
                {
                    tong += ct.THUOC.DONGIATHUOC * ct.SOLUONG;
                }
            }
            ViewBag.tongtien = tong;
            return View(hSBAs.ToList());
        }

        // GET: CT_HSBA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_HSBA cT_HSBA = db.CT_HSBA.Find(id);
            if (cT_HSBA == null)
            {
                return HttpNotFound();
            }
            return View(cT_HSBA);
        }

        // GET: CT_HSBA/Create
        public ActionResult Create()
        {
            ViewBag.MABS = new SelectList(db.BACSIs, "MABS", "TENBS");
            ViewBag.MAHSBA = new SelectList(db.HSBAs, "MAHSBA", "MAHSBA");
            return View();
        }

        // POST: CT_HSBA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAHSBA,MABS,NGAYKHAM,TINHTRANG")] CT_HSBA cT_HSBA)
        {
            if (ModelState.IsValid)
            {
                db.CT_HSBA.Add(cT_HSBA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MABS = new SelectList(db.BACSIs, "MABS", "TENBS", cT_HSBA.MABS);
            ViewBag.MAHSBA = new SelectList(db.HSBAs, "MAHSBA", "MAHSBA", cT_HSBA.MAHSBA);
            return View(cT_HSBA);
        }

        // GET: CT_HSBA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_HSBA cT_HSBA = db.CT_HSBA.Find(id);
            if (cT_HSBA == null)
            {
                return HttpNotFound();
            }
            ViewBag.MABS = new SelectList(db.BACSIs, "MABS", "TENBS", cT_HSBA.MABS);
            ViewBag.MAHSBA = new SelectList(db.HSBAs, "MAHSBA", "MAHSBA", cT_HSBA.MAHSBA);
            return View(cT_HSBA);
        }

        // POST: CT_HSBA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAHSBA,MABS,NGAYKHAM,TINHTRANG")] CT_HSBA cT_HSBA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cT_HSBA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MABS = new SelectList(db.BACSIs, "MABS", "TENBS", cT_HSBA.MABS);
            ViewBag.MAHSBA = new SelectList(db.HSBAs, "MAHSBA", "MAHSBA", cT_HSBA.MAHSBA);
            return View(cT_HSBA);
        }

        // GET: CT_HSBA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_HSBA cT_HSBA = db.CT_HSBA.Find(id);
            if (cT_HSBA == null)
            {
                return HttpNotFound();
            }
            return View(cT_HSBA);
        }

        // POST: CT_HSBA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CT_HSBA cT_HSBA = db.CT_HSBA.Find(id);
            db.CT_HSBA.Remove(cT_HSBA);
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
