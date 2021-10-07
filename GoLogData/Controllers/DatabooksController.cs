using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoLogData.Data;
using GoLogData.Models;

namespace GoLogData.Controllers
{
    public class DatabooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatabooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Databooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Databook.ToListAsync());
        }

        // GET: Databooks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var databook = await _context.Databook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (databook == null)
            {
                return NotFound();
            }

            return View(databook);
        }

        // GET: Databooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Databooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Databook databook)
        {
            if (ModelState.IsValid)
            {
                databook.Id = Guid.NewGuid();
                _context.Add(databook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(databook);
        }

        // GET: Databooks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var databook = await _context.Databook.FindAsync(id);
            if (databook == null)
            {
                return NotFound();
            }
            return View(databook);
        }

        // POST: Databooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id")] Databook databook)
        {
            if (id != databook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(databook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatabookExists(databook.Id))
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
            return View(databook);
        }

        // GET: Databooks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var databook = await _context.Databook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (databook == null)
            {
                return NotFound();
            }

            return View(databook);
        }

        // POST: Databooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var databook = await _context.Databook.FindAsync(id);
            _context.Databook.Remove(databook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatabookExists(Guid id)
        {
            return _context.Databook.Any(e => e.Id == id);
        }
    }
}
