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
    public class GheController : Controller
    {
        private readonly DPContext _context;

        public GheController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Ghe
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Ghe.Include(g => g.idlg).Include(g => g.idphong);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Ghe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.Ghe
                .Include(g => g.idlg)
                .Include(g => g.idphong)
                .FirstOrDefaultAsync(m => m.IDGhe == id);
            if (gheModel == null)
            {
                return NotFound();
            }

            return View(gheModel);
        }

        // GET: Admin/Ghe/Create
        public IActionResult Create()
        {
            ViewData["IDLG"] = new SelectList(_context.LoaiGhe, "IDLG", "IDLG");
            ViewData["IDPhong"] = new SelectList(_context.Phong, "IDPhong", "IDPhong");
            return View();
        }

        // POST: Admin/Ghe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDGhe,IDLG,IDPhong,TenGhe,SoGhe,TrangThai")] GheModel gheModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gheModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLG"] = new SelectList(_context.LoaiGhe, "IDLG", "IDLG", gheModel.IDLG);
            ViewData["IDPhong"] = new SelectList(_context.Phong, "IDPhong", "IDPhong", gheModel.IDPhong);
            return View(gheModel);
        }

        // GET: Admin/Ghe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.Ghe.FindAsync(id);
            if (gheModel == null)
            {
                return NotFound();
            }
            ViewData["IDLG"] = new SelectList(_context.LoaiGhe, "IDLG", "IDLG", gheModel.IDLG);
            ViewData["IDPhong"] = new SelectList(_context.Phong, "IDPhong", "IDPhong", gheModel.IDPhong);
            return View(gheModel);
        }

        // POST: Admin/Ghe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDGhe,IDLG,IDPhong,TenGhe,SoGhe,TrangThai")] GheModel gheModel)
        {
            if (id != gheModel.IDGhe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gheModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GheModelExists(gheModel.IDGhe))
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
            ViewData["IDLG"] = new SelectList(_context.LoaiGhe, "IDLG", "IDLG", gheModel.IDLG);
            ViewData["IDPhong"] = new SelectList(_context.Phong, "IDPhong", "IDPhong", gheModel.IDPhong);
            return View(gheModel);
        }

        // GET: Admin/Ghe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.Ghe
                .Include(g => g.idlg)
                .Include(g => g.idphong)
                .FirstOrDefaultAsync(m => m.IDGhe == id);
            if (gheModel == null)
            {
                return NotFound();
            }

            return View(gheModel);
        }

        // POST: Admin/Ghe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gheModel = await _context.Ghe.FindAsync(id);
            _context.Ghe.Remove(gheModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GheModelExists(int id)
        {
            return _context.Ghe.Any(e => e.IDGhe == id);
        }
    }
}
