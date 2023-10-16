using AutoMapper;
using bibliotecaVirtual.Data;
using bibliotecaVirtual.Data.DTOs;
using bibliotecaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace bibliotecaVirtual.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;



        public LivroController (AppDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public ActionResult Create ( [FromBody] CreateLivroDTO dto )
        {
            if ( dto == null )
            {
                return BadRequest();
            }
            Livro livro = _mapper.Map<Livro>( dto );

            _context.livro.Add( livro );
            _context.SaveChanges();
            return StatusCode(201, "Livro criado com sucesso" );
        }

        [HttpGet]
        public ActionResult<IEnumerable<Livro>> GetAll([FromQuery] int skip=0, [FromQuery] int take=25)
        {
            var Livros = _context.livro.Skip(skip).Take(take).ToList();
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
