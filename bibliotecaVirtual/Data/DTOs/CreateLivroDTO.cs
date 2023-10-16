using System.ComponentModel.DataAnnotations;

namespace bibliotecaVirtual.Data.DTOs
{
    public class CreateLivroDTO
    {
        [Required(ErrorMessage = "O Titulo não pode ser vazio")]
        public string Titulo { get; set; }

        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
    }
}
