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
    public class PhongController : Controller
    {
        private readonly DPContext _context;

        public PhongController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Phong
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Phong.Include(p => p.idrap);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Phong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongModel = await _context.Phong
                .Include(p => p.idrap)
                .FirstOrDefaultAsync(m => m.IDPhong == id);
            if (phongModel == null)
            {
                return NotFound();
            }

            return View(phongModel);
        }

        // GET: Admin/Phong/Create
        public IActionResult Create()
        {
            ViewData["IDRap"] = new SelectList(_context.Rap, "IDRap", "IDRap");
            return View();
        }

        // POST: Admin/Phong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPhong,SoPhong,TrangThai,IDRap")] PhongModel phongModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDRap"] = new SelectList(_context.Rap, "IDRap", "IDRap", phongModel.IDRap);
            return View(phongModel);
        }

        // GET: Admin/Phong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongModel = await _context.Phong.FindAsync(id);
            if (phongModel == null)
            {
                return NotFound();
            }
            ViewData["IDRap"] = new SelectList(_context.Rap, "IDRap", "IDRap", phongModel.IDRap);
            return View(phongModel);
        }

        // POST: Admin/Phong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDPhong,SoPhong,TrangThai,IDRap")] PhongModel phongModel)
        {
            if (id != phongModel.IDPhong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongModelExists(phongModel.IDPhong))
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
            ViewData["IDRap"] = new SelectList(_context.Rap, "IDRap", "IDRap", phongModel.IDRap);
            return View(phongModel);
        }

        // GET: Admin/Phong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongModel = await _context.Phong
                .Include(p => p.idrap)
                .FirstOrDefaultAsync(m => m.IDPhong == id);
            if (phongModel == null)
            {
                return NotFound();
            }

            return View(phongModel);
        }

        // POST: Admin/Phong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phongModel = await _context.Phong.FindAsync(id);
            _context.Phong.Remove(phongModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongModelExists(int id)
        {
            return _context.Phong.Any(e => e.IDPhong == id);
        }
    }
}
