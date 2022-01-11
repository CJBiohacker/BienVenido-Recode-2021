using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CurriculoesController : Controller
    {
        private readonly BancoDados _context;

        public CurriculoesController(BancoDados context)
        {
            _context = context;
        }

        // GET: Curriculoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Curriculos.ToListAsync());
        }

        // GET: Curriculoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculos
                .FirstOrDefaultAsync(m => m.idCurriculo == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // GET: Curriculoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Curriculoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCurriculo,Nome,Endereco,Telefone,Email,Nacionalidade,DataNasc,Empresa1,CargoTrab1,PeriodoTrab1,DescricaoTrab1,Empresa2,CargoTrab2,PeriodoTrab2,DescricaoTrab2,Instituicao1,Nivel1,Curso1,Instituicao2,Nivel2,Curso2,Habilidades,Idioma2,Idioma3")] Curriculo curriculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(curriculo);
        }

        // GET: Curriculoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculos.FindAsync(id);
            if (curriculo == null)
            {
                return NotFound();
            }
            return View(curriculo);
        }

        // POST: Curriculoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCurriculo,Nome,Endereco,Telefone,Email,Nacionalidade,DataNasc,Empresa1,CargoTrab1,PeriodoTrab1,DescricaoTrab1,Empresa2,CargoTrab2,PeriodoTrab2,DescricaoTrab2,Instituicao1,Nivel1,Curso1,Instituicao2,Nivel2,Curso2,Habilidades,Idioma2,Idioma3")] Curriculo curriculo)
        {
            if (id != curriculo.idCurriculo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculoExists(curriculo.idCurriculo))
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
            return View(curriculo);
        }

        // GET: Curriculoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculos
                .FirstOrDefaultAsync(m => m.idCurriculo == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // POST: Curriculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curriculo = await _context.Curriculos.FindAsync(id);
            _context.Curriculos.Remove(curriculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculoExists(int id)
        {
            return _context.Curriculos.Any(e => e.idCurriculo == id);
        }
    }
}
