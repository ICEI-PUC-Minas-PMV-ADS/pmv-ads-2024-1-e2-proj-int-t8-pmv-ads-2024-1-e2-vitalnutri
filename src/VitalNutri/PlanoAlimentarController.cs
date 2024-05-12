using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Data;
using VitalNutri.Models;

namespace VitalNutri
{
    public class PlanoAlimentarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanoAlimentarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlanoAlimentar
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PlanosAlimentares.Include(p => p.Cliente).Include(p => p.Nutricionista);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PlanoAlimentar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .Include(p => p.Cliente)
                .Include(p => p.Nutricionista)
                .FirstOrDefaultAsync(m => m.PlanoAlimentarId == id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }

            return View(planoAlimentar);
        }

        // GET: PlanoAlimentar/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId");
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId");
            return View();
        }

        // POST: PlanoAlimentar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlanoAlimentarId,Nome,NutricionistaId,Horario,Alimento,Quantidade,ClienteId")] PlanoAlimentar planoAlimentar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planoAlimentar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", planoAlimentar.ClienteId);
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId", planoAlimentar.NutricionistaId);
            return View(planoAlimentar);
        }

        // GET: PlanoAlimentar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares.FindAsync(id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", planoAlimentar.ClienteId);
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId", planoAlimentar.NutricionistaId);
            return View(planoAlimentar);
        }

        // POST: PlanoAlimentar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlanoAlimentarId,Nome,NutricionistaId,Horario,Alimento,Quantidade,ClienteId")] PlanoAlimentar planoAlimentar)
        {
            if (id != planoAlimentar.PlanoAlimentarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planoAlimentar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoAlimentarExists(planoAlimentar.PlanoAlimentarId))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", planoAlimentar.ClienteId);
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId", planoAlimentar.NutricionistaId);
            return View(planoAlimentar);
        }

        // GET: PlanoAlimentar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .Include(p => p.Cliente)
                .Include(p => p.Nutricionista)
                .FirstOrDefaultAsync(m => m.PlanoAlimentarId == id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }

            return View(planoAlimentar);
        }

        // POST: PlanoAlimentar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planoAlimentar = await _context.PlanosAlimentares.FindAsync(id);
            if (planoAlimentar != null)
            {
                _context.PlanosAlimentares.Remove(planoAlimentar);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoAlimentarExists(int id)
        {
            return _context.PlanosAlimentares.Any(e => e.PlanoAlimentarId == id);
        }
    }
}
