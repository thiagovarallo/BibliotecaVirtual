using bibliotecaVirtual.Data;
using bibliotecaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace bibliotecaVirtual.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivroController (AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult Create ( [FromBody] Livro livro )
        {
            if ( livro == null )
            {
                return BadRequest();
            }
            _context.livro.Add( livro );
            _context.SaveChanges();
            return StatusCode(201, "Livro criado com sucesso" );
        }

        [HttpGet]
        public ActionResult<IEnumerable<Livro>> GetAll ()
        {
            var Livros = _context.livro.ToList();
            return Ok( Livros );
        }

        [HttpGet("{id}")]
        public ActionResult<Livro> GetById (int id)
        {
            if (id is 0) { return BadRequest(); }
            Livro livro = _context.livro.Find(id);

            if (livro == null)
            {
                return NotFound("Livro não localizado");
            }

            return Ok( livro );
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById (int id)
        {
            if (id is 0) { return BadRequest();}

            Livro livro = _context.livro.Find(id);
            
            if (livro == null)
            {
                return NotFound("Livro não localizado");
            }

            _context.livro.Remove(livro);
            _context.SaveChanges();

            return Ok("Livro Removido com sucesso");
        }
    }
}
