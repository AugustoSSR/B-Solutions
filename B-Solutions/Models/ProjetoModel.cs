using B_Solutions.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class ProjetoModel
    {
        public int projetoId { get; set; }
        [Required(ErrorMessage = "Selecione o nome do projeto.")]
        public string projetoNome { get; set; }
        [Required(ErrorMessage = "Selecione a empresa do projeto.")]
        public string projetoEmpresa { get; set; }  
        [Required(ErrorMessage = "Selecione o tipo do projeto.")]
        public string projetoTipo { get; set; }
        [Required(ErrorMessage = "Selecione a concessionaria.")]
        public string projetoConcessionaria { get; set; }
        [Required(ErrorMessage = "Digite a localidade do projeto.")]
        public string projetoLocalidade { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string projetoEngenheiro { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string projetoStatus { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string projetoART { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string projetoProtocolo { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string projetoObservacao { get; set; }
        public DateTime projetoDataCadastro { get; set; }
        public DateTime? projetoDataAlteracao { get; set; }
    }
}
