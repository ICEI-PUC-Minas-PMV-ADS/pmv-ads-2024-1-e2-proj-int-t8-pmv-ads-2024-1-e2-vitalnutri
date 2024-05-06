using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Data;
using VitalNutri.Models;

namespace VitalNutri.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Clientes.Include(c => c.Nutricionista).Include(c => c.TreinadorPessoal).Include(c => c.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Nutricionista)
                .Include(c => c.TreinadorPessoal)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "Id", "Id");
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "Id", "Id");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Ativo");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,NutricionistaId,TreinadorPessoalId,PossuiAcompanhamentoNutricionista,PossuiAcompanhamentoPersonal,PossuiPlanoAlimentar,PossuiPlanoTreino,Peso,Altura,MetaPeso")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "Id", "Id", cliente.NutricionistaId);
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "Id", "Id", cliente.TreinadorPessoalId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Ativo", cliente.UsuarioId);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "Id", "Id", cliente.NutricionistaId);
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "Id", "Id", cliente.TreinadorPessoalId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Ativo", cliente.UsuarioId);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuarioId,NutricionistaId,TreinadorPessoalId,PossuiAcompanhamentoNutricionista,PossuiAcompanhamentoPersonal,PossuiPlanoAlimentar,PossuiPlanoTreino,Peso,Altura,MetaPeso")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            ViewData["NutricionistaId"] = new SelectList(_context.Nutricionistas, "Id", "Id", cliente.NutricionistaId);
            ViewData["TreinadorPessoalId"] = new SelectList(_context.TreinadoresPessoais, "Id", "Id", cliente.TreinadorPessoalId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Ativo", cliente.UsuarioId);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Nutricionista)
                .Include(c => c.TreinadorPessoal)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
