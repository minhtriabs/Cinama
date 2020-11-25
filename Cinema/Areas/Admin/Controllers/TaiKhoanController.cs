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
    public class TaiKhoanController : Controller
    {
        private readonly DPContext _context;

        public TaiKhoanController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/TaiKhoan
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.TaiKhoan.Include(t => t.idltk);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/TaiKhoan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoan
                .Include(t => t.idltk)
                .FirstOrDefaultAsync(m => m.IDTK == id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Create
        public IActionResult Create()
        {
            ViewData["IDLTK"] = new SelectList(_context.LoaiTK, "IDLTK", "IDLTK");
            return View();
        }

        // POST: Admin/TaiKhoan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDTK,IDLTK,Ten,Ho,GioiTinh,DienThoai,NgaySinh,Email,DiaChi,AnhDaiDien,TaiKhoan,MatKhau,TrangThai")] TaiKhoanModel taiKhoanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLTK"] = new SelectList(_context.LoaiTK, "IDLTK", "IDLTK", taiKhoanModel.IDLTK);
            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }
            ViewData["IDLTK"] = new SelectList(_context.LoaiTK, "IDLTK", "IDLTK", taiKhoanModel.IDLTK);
            return View(taiKhoanModel);
        }

        // POST: Admin/TaiKhoan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDTK,IDLTK,Ten,Ho,GioiTinh,DienThoai,NgaySinh,Email,DiaChi,AnhDaiDien,TaiKhoan,MatKhau,TrangThai")] TaiKhoanModel taiKhoanModel)
        {
            if (id != taiKhoanModel.IDTK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanModelExists(taiKhoanModel.IDTK))
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
            ViewData["IDLTK"] = new SelectList(_context.LoaiTK, "IDLTK", "IDLTK", taiKhoanModel.IDLTK);
            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoan
                .Include(t => t.idltk)
                .FirstOrDefaultAsync(m => m.IDTK == id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return View(taiKhoanModel);
        }

        // POST: Admin/TaiKhoan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taiKhoanModel = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanModelExists(int id)
        {
            return _context.TaiKhoan.Any(e => e.IDTK == id);
        }
    }
}
