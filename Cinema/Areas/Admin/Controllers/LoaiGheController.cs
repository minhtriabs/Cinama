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
    public class LoaiGheController : Controller
    {
        private readonly DPContext _context;

        public LoaiGheController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiGhe
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiGhe.ToListAsync());
        }

        // GET: Admin/LoaiGhe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiGheModel = await _context.LoaiGhe
                .FirstOrDefaultAsync(m => m.IDLG == id);
            if (loaiGheModel == null)
            {
                return NotFound();
            }

            return View(loaiGheModel);
        }

        // GET: Admin/LoaiGhe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiGhe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDLG,TenLoai,GiaLG,TrangThai")] LoaiGheModel loaiGheModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiGheModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiGheModel);
        }

        // GET: Admin/LoaiGhe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiGheModel = await _context.LoaiGhe.FindAsync(id);
            if (loaiGheModel == null)
            {
                return NotFound();
            }
            return View(loaiGheModel);
        }

        // POST: Admin/LoaiGhe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDLG,TenLoai,GiaLG,TrangThai")] LoaiGheModel loaiGheModel)
        {
            if (id != loaiGheModel.IDLG)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiGheModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiGheModelExists(loaiGheModel.IDLG))
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
            return View(loaiGheModel);
        }

        // GET: Admin/LoaiGhe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiGheModel = await _context.LoaiGhe
                .FirstOrDefaultAsync(m => m.IDLG == id);
            if (loaiGheModel == null)
            {
                return NotFound();
            }

            return View(loaiGheModel);
        }

        // POST: Admin/LoaiGhe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiGheModel = await _context.LoaiGhe.FindAsync(id);
            _context.LoaiGhe.Remove(loaiGheModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiGheModelExists(int id)
        {
            return _context.LoaiGhe.Any(e => e.IDLG == id);
        }
    }
}
