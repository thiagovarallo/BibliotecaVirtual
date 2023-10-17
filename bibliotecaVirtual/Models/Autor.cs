using System.ComponentModel.DataAnnotations;

namespace bibliotecaVirtual.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(120, ErrorMessage = "O nome deve ter no minimo 120 caracteres")]
        public string NOme { get; set; }
        [Required]
        [StringLength(120, ErrorMessage = "A nacionalidade deve ter no minimo 120 caracteres")]
        public string Nacionalidade { get; set; }
    }
}
