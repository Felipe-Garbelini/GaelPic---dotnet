using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GaelPic.Data;
using GaelPic.Models;

namespace GaelPic.Controllers
{
    public class TypesMidiasController : Controller
    {
        private readonly GaelPicContext _context;

        public TypesMidiasController(GaelPicContext context)
        {
            _context = context;
        }

        // GET: TypesMidias
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeMidia.ToListAsync());
        }

        // GET: TypesMidias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeMidia = await _context.TypeMidia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeMidia == null)
            {
                return NotFound();
            }

            return View(typeMidia);
        }

        // GET: TypesMidias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypesMidias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] TypeMidia typeMidia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeMidia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeMidia);
        }

        // GET: TypesMidias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeMidia = await _context.TypeMidia.FindAsync(id);
            if (typeMidia == null)
            {
                return NotFound();
            }
            return View(typeMidia);
        }

        // POST: TypesMidias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] TypeMidia typeMidia)
        {
            if (id != typeMidia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeMidia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeMidiaExists(typeMidia.Id))
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
            return View(typeMidia);
        }

        // GET: TypesMidias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeMidia = await _context.TypeMidia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeMidia == null)
            {
                return NotFound();
            }

            return View(typeMidia);
        }

        // POST: TypesMidias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeMidia = await _context.TypeMidia.FindAsync(id);
            if (typeMidia != null)
            {
                _context.TypeMidia.Remove(typeMidia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeMidiaExists(int id)
        {
            return _context.TypeMidia.Any(e => e.Id == id);
        }
    }
}
