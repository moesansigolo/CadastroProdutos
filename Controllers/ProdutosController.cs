using CadastroProdutos.Data;
using CadastroProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Microsoft.AspNet.OData.EnableQuery]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            
            return await _context.Produtos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetById(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return BadRequest("Produto não encontardo.");
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<List<Produto>>> AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Produto>>> AtualizarProduto(int? id, [FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);

            if (id == null) return BadRequest("Produto não existe.");
            await _context.SaveChangesAsync();
            return Ok(produto);           
            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Produto>>> DeletarProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return BadRequest("Produto não encontrado.");
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return Ok("Produto excluido com sucesso.");
           
        }
    }
}
