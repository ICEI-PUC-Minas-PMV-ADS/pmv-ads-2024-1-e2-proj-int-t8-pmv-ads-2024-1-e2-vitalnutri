﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Data;
using VitalNutri.Models;
using VitalNutri.Services;

namespace VitalNutri.Areas.Nutricionista.Controllers
{
    [Area("Nutricionista")]
    [Authorize(Roles = "Nutricionista")]
    public class AlimentoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly AlimentoService _alimentoService;

        public AlimentoController(ApplicationDbContext context, AlimentoService alimentoService)
        {
            _context = context;
            _alimentoService = alimentoService;
        }

        // GET: Nutricionista/Alimento
        public async Task<IActionResult> Index()
        {
            var alimentosDoUsuario = _alimentoService.ObterAlimentosDoUsuarioAtual();
            return View(alimentosDoUsuario.ToList());
            //var applicationDbContext = _context.Alimentos.Include(a => a.Nutricionista);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Nutricionista/Alimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimento = await _context.Alimentos
                .Include(a => a.Nutricionista)
                .FirstOrDefaultAsync(m => m.AlimentoId == id);
            if (alimento == null)
            {
                return NotFound();
            }

            return View(alimento);
        }

        // GET: Nutricionista/Alimento/Create
        public IActionResult Create()
        {
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId");
            return View();
        }

        // POST: Nutricionista/Alimento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlimentoId,Nome,Calorias,Carboidratos,Gorduras,Proteinas,NutricionistaId")] Alimento alimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId", alimento.NutricionistaId);
            return View(alimento);
        }

        // GET: Nutricionista/Alimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimento = await _context.Alimentos.FindAsync(id);
            if (alimento == null)
            {
                return NotFound();
            }
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId", alimento.NutricionistaId);
            return View(alimento);
        }

        // POST: Nutricionista/Alimento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlimentoId,Nome,Calorias,Carboidratos,Gorduras,Proteinas,NutricionistaId")] Alimento alimento)
        {
            if (id != alimento.AlimentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlimentoExists(alimento.AlimentoId))
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
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "NutricionistaId", "NutricionistaId", alimento.NutricionistaId);
            return View(alimento);
        }

        // GET: Nutricionista/Alimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimento = await _context.Alimentos
                .Include(a => a.Nutricionista)
                .FirstOrDefaultAsync(m => m.AlimentoId == id);
            if (alimento == null)
            {
                return NotFound();
            }

            return View(alimento);
        }

        // POST: Nutricionista/Alimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alimento = await _context.Alimentos.FindAsync(id);
            if (alimento != null)
            {
                _context.Alimentos.Remove(alimento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlimentoExists(int id)
        {
            return _context.Alimentos.Any(e => e.AlimentoId == id);
        }
    }
}
