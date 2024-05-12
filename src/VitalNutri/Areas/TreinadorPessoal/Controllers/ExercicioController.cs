using System;
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

namespace VitalNutri.Areas.TreinadorPessoal.Controllers
{
    [Area("TreinadorPessoal")]
    [Authorize(Roles = "TreinadorPessoal")]
    public class ExercicioController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly AlimentoService _alimentoService;

        public ExercicioController(ApplicationDbContext context, AlimentoService alimentoService)
        {
            _context = context;
            _alimentoService = alimentoService; // Atribua o serviço à variável local
        }

        // GET: TreinadorPessoal/Exercicio
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Exercicios.Include(e => e.TreinadorPessoal);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TreinadorPessoal/Exercicio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicios
                .Include(e => e.TreinadorPessoal)
                .FirstOrDefaultAsync(m => m.ExercicioId == id);
            if (exercicio == null)
            {
                return NotFound();
            }

            return View(exercicio);
        }

        // GET: TreinadorPessoal/Exercicio/Create
        public IActionResult Create()
        {
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "TreinadorPessoalId", "TreinadorPessoalId");
            return View();
        }

        // POST: TreinadorPessoal/Exercicio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExercicioId,Nome,Descricao,TreinadorPessoalId,Imagem")] Exercicio exercicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exercicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "TreinadorPessoalId", "TreinadorPessoalId", exercicio.TreinadorPessoalId);
            return View(exercicio);
        }

        // GET: TreinadorPessoal/Exercicio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicios.FindAsync(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "TreinadorPessoalId", "TreinadorPessoalId", exercicio.TreinadorPessoalId);
            return View(exercicio);
        }

        // POST: TreinadorPessoal/Exercicio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExercicioId,Nome,Descricao,TreinadorPessoalId,Imagem")] Exercicio exercicio)
        {
            if (id != exercicio.ExercicioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExercicioExists(exercicio.ExercicioId))
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
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "TreinadorPessoalId", "TreinadorPessoalId", exercicio.TreinadorPessoalId);
            return View(exercicio);
        }

        // GET: TreinadorPessoal/Exercicio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicios
                .Include(e => e.TreinadorPessoal)
                .FirstOrDefaultAsync(m => m.ExercicioId == id);
            if (exercicio == null)
            {
                return NotFound();
            }

            return View(exercicio);
        }

        // POST: TreinadorPessoal/Exercicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exercicio = await _context.Exercicios.FindAsync(id);
            if (exercicio != null)
            {
                _context.Exercicios.Remove(exercicio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExercicioExists(int id)
        {
            return _context.Exercicios.Any(e => e.ExercicioId == id);
        }
    }
}
