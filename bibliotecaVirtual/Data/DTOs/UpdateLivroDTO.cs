using System.ComponentModel.DataAnnotations;

namespace bibliotecaVirtual.Data.DTOs
{
    public class UpdateLivroDTO
    {
        [Required(ErrorMessage = "O Titulo não pode ser vazio")]
        [StringLength(120, ErrorMessage = "O Titulo deve ter no minimo 120 caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo autor não pode ser fazio")]
        [StringLength(120, ErrorMessage = "O autor deve ter no minimo 120 caracteres")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O campo ano de publicação não pode ser fazio")]
        [Range(1, 2025, ErrorMessage = "O ano de publicação deve estar entre 1 à 2025")]
        public int AnoPublicacao { get; set; }
    }
}
