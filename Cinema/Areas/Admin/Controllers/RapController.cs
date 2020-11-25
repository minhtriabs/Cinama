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
    public class RapController : Controller
    {
        private readonly DPContext _context;

        public RapController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Rap
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Rap.Include(r => r.idthanhpho);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Rap/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapModel = await _context.Rap
                .Include(r => r.idthanhpho)
                .FirstOrDefaultAsync(m => m.IDRap == id);
            if (rapModel == null)
            {
                return NotFound();
            }

            return View(rapModel);
        }

        // GET: Admin/Rap/Create
        public IActionResult Create()
        {
            ViewData["IDTP"] = new SelectList(_context.ThanhPho, "IDTP", "IDTP");
            return View();
        }

        // POST: Admin/Rap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDRap,TenRap,TrangThai,IDTP")] RapModel rapModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rapModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDTP"] = new SelectList(_context.ThanhPho, "IDTP", "IDTP", rapModel.IDTP);
            return View(rapModel);
        }

        // GET: Admin/Rap/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapModel = await _context.Rap.FindAsync(id);
            if (rapModel == null)
            {
                return NotFound();
            }
            ViewData["IDTP"] = new SelectList(_context.ThanhPho, "IDTP", "IDTP", rapModel.IDTP);
            return View(rapModel);
        }

        // POST: Admin/Rap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDRap,TenRap,TrangThai,IDTP")] RapModel rapModel)
        {
            if (id != rapModel.IDRap)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rapModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RapModelExists(rapModel.IDRap))
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
            ViewData["IDTP"] = new SelectList(_context.ThanhPho, "IDTP", "IDTP", rapModel.IDTP);
            return View(rapModel);
        }

        // GET: Admin/Rap/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapModel = await _context.Rap
                .Include(r => r.idthanhpho)
                .FirstOrDefaultAsync(m => m.IDRap == id);
            if (rapModel == null)
            {
                return NotFound();
            }

            return View(rapModel);
        }

        // POST: Admin/Rap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rapModel = await _context.Rap.FindAsync(id);
            _context.Rap.Remove(rapModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapModelExists(int id)
        {
            return _context.Rap.Any(e => e.IDRap == id);
        }
    }
}
