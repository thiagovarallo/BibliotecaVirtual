using System.ComponentModel.DataAnnotations;

namespace bibliotecaVirtual.Models
{
    public class Editora
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(120, ErrorMessage = "O nome deve ter no minimo 120 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(120, ErrorMessage = "O endereço deve ter no minimo 120 caracteres")]
        public string endereco { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "O nome deve ter no minimo 15 caracteres")]
        public string Telefone { get; set; }

    }
}
