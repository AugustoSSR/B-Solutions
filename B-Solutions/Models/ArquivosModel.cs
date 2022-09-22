using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class ArquivosModel
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string numeroCaderno { get; set; }
        [Required]
        public string Empresa { get; set; }
        [Required]
        public string Localidade { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
