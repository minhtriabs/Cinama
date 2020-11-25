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
    public class KhungGioController : Controller
    {
        private readonly DPContext _context;

        public KhungGioController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/KhungGio
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.KhungGio.Include(k => k.idphim);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/KhungGio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khungGioModel = await _context.KhungGio
                .Include(k => k.idphim)
                .FirstOrDefaultAsync(m => m.IDKG == id);
            if (khungGioModel == null)
            {
                return NotFound();
            }

            return View(khungGioModel);
        }

        // GET: Admin/KhungGio/Create
        public IActionResult Create()
        {
            ViewData["IDPhim"] = new SelectList(_context.Phim, "IDPhim", "IDPhim");
            return View();
        }

        // POST: Admin/KhungGio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDKG,IDPhim,ThoiGian,TrangThai")] KhungGioModel khungGioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khungGioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDPhim"] = new SelectList(_context.Phim, "IDPhim", "IDPhim", khungGioModel.IDPhim);
            return View(khungGioModel);
        }

        // GET: Admin/KhungGio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khungGioModel = await _context.KhungGio.FindAsync(id);
            if (khungGioModel == null)
            {
                return NotFound();
            }
            ViewData["IDPhim"] = new SelectList(_context.Phim, "IDPhim", "IDPhim", khungGioModel.IDPhim);
            return View(khungGioModel);
        }

        // POST: Admin/KhungGio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDKG,IDPhim,ThoiGian,TrangThai")] KhungGioModel khungGioModel)
        {
            if (id != khungGioModel.IDKG)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khungGioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhungGioModelExists(khungGioModel.IDKG))
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
            ViewData["IDPhim"] = new SelectList(_context.Phim, "IDPhim", "IDPhim", khungGioModel.IDPhim);
            return View(khungGioModel);
        }

        // GET: Admin/KhungGio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khungGioModel = await _context.KhungGio
                .Include(k => k.idphim)
                .FirstOrDefaultAsync(m => m.IDKG == id);
            if (khungGioModel == null)
            {
                return NotFound();
            }

            return View(khungGioModel);
        }

        // POST: Admin/KhungGio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khungGioModel = await _context.KhungGio.FindAsync(id);
            _context.KhungGio.Remove(khungGioModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhungGioModelExists(int id)
        {
            return _context.KhungGio.Any(e => e.IDKG == id);
        }
    }
}
