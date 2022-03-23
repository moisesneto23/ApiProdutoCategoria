using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProdutoCategoria.Context;
using ProdutoCategoria.Modelos;

namespace ProdutoCategoria.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    
    public class CategoriaController : Controller
    {
        private readonly MyContext _context;

        public CategoriaController(MyContext context)
        {
            _context = context;
        }

        // GET: Categoria
        [HttpGet]
        public ActionResult< IEnumerable<Categoria>> GetCategorias()
        {
            return Ok(_context.Categorias.AsNoTracking().ToListAsync());
        }

        //// GET: Categoria/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var categoria = await _context.Categorias
        //        .FirstOrDefaultAsync(m => m.CategoriaId == id);
        //    if (categoria == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(categoria);
        //}

        //// GET: Categoria/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Categoria/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("CategoriaId,Nome,ImgUrl")] Categoria categoria)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(categoria);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(categoria);
        //}

        //// GET: Categoria/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var categoria = await _context.Categorias.FindAsync(id);
        //    if (categoria == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(categoria);
        //}

        //// POST: Categoria/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("CategoriaId,Nome,ImgUrl")] Categoria categoria)
        //{
        //    if (id != categoria.CategoriaId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(categoria);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CategoriaExists(categoria.CategoriaId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(categoria);
        //}

        //// GET: Categoria/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var categoria = await _context.Categorias
        //        .FirstOrDefaultAsync(m => m.CategoriaId == id);
        //    if (categoria == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(categoria);
        //}

        //// POST: Categoria/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var categoria = await _context.Categorias.FindAsync(id);
        //    _context.Categorias.Remove(categoria);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CategoriaExists(int id)
        //{
        //    return _context.Categorias.Any(e => e.CategoriaId == id);
        //}
    }
}
