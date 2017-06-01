﻿using DACK_WEB2.Models.Bus;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DACK_WEB2.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSanPham
        public ActionResult Index(int id, int page = 1, int pagesize = 3)
        {
            var dsloaisp = LoaiSanPhamBUS.ChiTiet(id).ToPagedList(page, pagesize);
            return View(dsloaisp);
        } 

        // GET: LoaiSanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoaiSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiSanPham/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoaiSanPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoaiSanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoaiSanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoaiSanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
