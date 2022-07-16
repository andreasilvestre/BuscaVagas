using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuscaVagas.Data;
using BuscaVagas.Models;

namespace BuscaVagas.Controllers
{
    public class VagasController : Controller
    {
        private readonly BuscaVagasContext _context;

        public VagasController(BuscaVagasContext context)
        {
            _context = context;
        }

        // GET: Vagas
        public async Task<IActionResult> Index()
        {
            var buscaVagasContext = _context.Vaga.Include(v => v.Empresa);
            return View(await buscaVagasContext.ToListAsync());
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vaga == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vaga
                .Include(v => v.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaga == null)
            {
                return NotFound();
            }

            return View(vaga);
        }

        // GET: Vagas/Create
        public IActionResult Create()
        {
            ViewData["Cnpj"] = new SelectList(_context.Empresa, "Cnpj", "Cnpj");
            return View();
        }

        // POST: Vagas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cnpj,Cargo,Nivel,Tecnologia,Cidade,Estado")] Vaga vaga)
        {
            try
            {


                //if (ModelState.IsValid)
               // {
                    _context.Add(vaga);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                //}
                ViewData["Cnpj"] = new SelectList(_context.Empresa, "Cnpj", "Cnpj", vaga.Cnpj);
            }
            catch(Exception ex)
            {

            }
            return View(vaga);
        }

        // GET: Vagas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vaga == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vaga.FindAsync(id);
            if (vaga == null)
            {
                return NotFound();
            }
            ViewData["Cnpj"] = new SelectList(_context.Empresa, "Cnpj", "Cnpj", vaga.Cnpj);
            return View(vaga);
        }

        // POST: Vagas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cnpj,Cargo,Nivel,Tecnologia,Cidade,Estado")] Vaga vaga)
        {
            if (id != vaga.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(vaga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagaExists(vaga.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["Cnpj"] = new SelectList(_context.Empresa, "Cnpj", "Cnpj", vaga.Cnpj);
            return View(vaga);
        }

        // GET: Vagas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vaga == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vaga
                .Include(v => v.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaga == null)
            {
                return NotFound();
            }

            return View(vaga);
        }

        // POST: Vagas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vaga == null)
            {
                return Problem("Entity set 'BuscaVagasContext.Vaga'  is null.");
            }
            var vaga = await _context.Vaga.FindAsync(id);
            if (vaga != null)
            {
                _context.Vaga.Remove(vaga);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VagaExists(int id)
        {
          return (_context.Vaga?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
