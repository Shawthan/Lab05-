using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab05.Models;

namespace Lab05.Controllers
{
    public class CharacterProgressionsController : Controller
    {
        private readonly GearContext _context;

        public CharacterProgressionsController(GearContext context)
        {
            _context = context;
        }

        // GET: CharacterProgressions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Charc.ToListAsync());
        }

        // GET: CharacterProgressions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterProgression = await _context.Charc
                .FirstOrDefaultAsync(m => m.ID == id);
            if (characterProgression == null)
            {
                return NotFound();
            }

            return View(characterProgression);
        }

        // GET: CharacterProgressions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CharacterProgressions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,make,model,gearGoal,gearMeso")] CharacterProgression characterProgression)
        {
            if (ModelState.IsValid)
            {
                _context.Add(characterProgression);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(characterProgression);
        }

        // GET: CharacterProgressions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterProgression = await _context.Charc.FindAsync(id);
            if (characterProgression == null)
            {
                return NotFound();
            }
            return View(characterProgression);
        }

        // POST: CharacterProgressions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,make,model,gearGoal,gearMeso")] CharacterProgression characterProgression)
        {
            if (id != characterProgression.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(characterProgression);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterProgressionExists(characterProgression.ID))
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
            return View(characterProgression);
        }

        // GET: CharacterProgressions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterProgression = await _context.Charc
                .FirstOrDefaultAsync(m => m.ID == id);
            if (characterProgression == null)
            {
                return NotFound();
            }

            return View(characterProgression);
        }

        // POST: CharacterProgressions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var characterProgression = await _context.Charc.FindAsync(id);
            _context.Charc.Remove(characterProgression);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterProgressionExists(int id)
        {
            return _context.Charc.Any(e => e.ID == id);
        }
    }
}
