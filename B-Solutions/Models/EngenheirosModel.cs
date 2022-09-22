using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class EngenheirosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Coloque o nome completo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Coloque o CPF.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Coloque o numero do CREA.")]
        public string CREA { get; set; }
        [Required(ErrorMessage = "Coloque o e-mail.")]
        public string Email { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
