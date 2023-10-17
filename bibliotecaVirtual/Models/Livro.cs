using System;
using System.ComponentModel.DataAnnotations;

namespace bibliotecaVirtual.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo titulo não pode ser fazio")]
        [StringLength(120, ErrorMessage = "O Titulo deve ter no minimo 120 caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo autor não pode ser fazio")]
        [StringLength(120, ErrorMessage = "O autor deve ter no minimo 120 caracteres")]

        public string Autor { get; set; }
        [Required(ErrorMessage = "O anoo de publicação não deve ser obrigatorio")]
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
