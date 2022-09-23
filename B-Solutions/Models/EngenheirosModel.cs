using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class EngenheirosModel
    {
        public int engenheiroId { get; set; }
        [Required(ErrorMessage = "Coloque o nome completo.")]
        public string engenheiroNome { get; set; }
        [Required(ErrorMessage = "Coloque o CPF.")]
        public string engenheiroCPF { get; set; }
        [Required(ErrorMessage = "Coloque o numero do CREA.")]
        public string engenheiroCREA { get; set; }
        [Required(ErrorMessage = "Coloque o e-mail.")]
        public string engenheiroEmail { get; set; }
        public DateTime engenheiroDataCadastro { get; set; }
        public DateTime? engenheiroDataAlteracao { get; set; }
    }
}
