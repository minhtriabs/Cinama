using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Areas.Admin.Controllers
{
    public class ThongTinController : Controller
    {
        [Area("Admin")]
        // GET: ThongTinController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThongTinController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThongTinController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongTinController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThongTinController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThongTinController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThongTinController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThongTinController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
