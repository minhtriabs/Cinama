using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;

namespace Cinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThanhPhoController : Controller
    {
        private readonly DPContext _context;

        public ThanhPhoController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/ThanhPho
        public async Task<IActionResult> Index()
        {
            return View(await _context.ThanhPho.ToListAsync());
        }

        // GET: Admin/ThanhPho/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thanhPhoModel = await _context.ThanhPho
                .FirstOrDefaultAsync(m => m.IDTP == id);
            if (thanhPhoModel == null)
            {
                return NotFound();
            }

            return View(thanhPhoModel);
        }

        // GET: Admin/ThanhPho/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ThanhPho/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDTP,TenTP,TrangThai")] ThanhPhoModel thanhPhoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thanhPhoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thanhPhoModel);
        }

        // GET: Admin/ThanhPho/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thanhPhoModel = await _context.ThanhPho.FindAsync(id);
            if (thanhPhoModel == null)
            {
                return NotFound();
            }
            return View(thanhPhoModel);
        }

        // POST: Admin/ThanhPho/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDTP,TenTP,TrangThai")] ThanhPhoModel thanhPhoModel)
        {
            if (id != thanhPhoModel.IDTP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thanhPhoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThanhPhoModelExists(thanhPhoModel.IDTP))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(thanhPhoModel);
        }

        // GET: Admin/ThanhPho/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thanhPhoModel = await _context.ThanhPho
                .FirstOrDefaultAsync(m => m.IDTP == id);
            if (thanhPhoModel == null)
            {
                return NotFound();
            }

            return View(thanhPhoModel);
        }

        // POST: Admin/ThanhPho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thanhPhoModel = await _context.ThanhPho.FindAsync(id);
            _context.ThanhPho.Remove(thanhPhoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThanhPhoModelExists(int id)
        {
            return _context.ThanhPho.Any(e => e.IDTP == id);
        }
    }
}
