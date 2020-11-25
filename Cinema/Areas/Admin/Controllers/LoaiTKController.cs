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
    public class LoaiTKController : Controller
    {
        private readonly DPContext _context;

        public LoaiTKController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiTK
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiTK.ToListAsync());
        }

        // GET: Admin/LoaiTK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiTKModel = await _context.LoaiTK
                .FirstOrDefaultAsync(m => m.IDLTK == id);
            if (loaiTKModel == null)
            {
                return NotFound();
            }

            return View(loaiTKModel);
        }

        // GET: Admin/LoaiTK/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiTK/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDLTK,TenLTK,TrangThai")] LoaiTKModel loaiTKModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiTKModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiTKModel);
        }

        // GET: Admin/LoaiTK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiTKModel = await _context.LoaiTK.FindAsync(id);
            if (loaiTKModel == null)
            {
                return NotFound();
            }
            return View(loaiTKModel);
        }

        // POST: Admin/LoaiTK/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDLTK,TenLTK,TrangThai")] LoaiTKModel loaiTKModel)
        {
            if (id != loaiTKModel.IDLTK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiTKModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiTKModelExists(loaiTKModel.IDLTK))
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
            return View(loaiTKModel);
        }

        // GET: Admin/LoaiTK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiTKModel = await _context.LoaiTK
                .FirstOrDefaultAsync(m => m.IDLTK == id);
            if (loaiTKModel == null)
            {
                return NotFound();
            }

            return View(loaiTKModel);
        }

        // POST: Admin/LoaiTK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiTKModel = await _context.LoaiTK.FindAsync(id);
            _context.LoaiTK.Remove(loaiTKModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiTKModelExists(int id)
        {
            return _context.LoaiTK.Any(e => e.IDLTK == id);
        }
    }
}
