using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProdutoCategoria.Context;

namespace ProdutoCategoria.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class ProdutoController : ControllerBase
    {
        private readonly MyContext _context;

        public ProdutoController(MyContext context)
        {
            _context = context;
        }

        // GET: Produto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetTodos()
        {
            
            return Ok(await _context.Produtos.ToListAsync());
        }

        // GET: Produto/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos                
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {

            _context.Produtos.Add(produto);
            _context.SaveChangesAsync();

            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }
            else
            {
                _context.Entry(produto).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok();
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<Produto> Deletar(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p=>p.ProdutoId==id);
            if(produto == null)
            {
                return BadRequest();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
                return Ok(produto);
        }

    
    }
}
