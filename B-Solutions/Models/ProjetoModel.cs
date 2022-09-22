using B_Solutions.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class ProjetoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Selecione a empresa do projeto.")]
        public string Empresa { get; set; }  
        [Required(ErrorMessage = "Selecione o tipo do projeto.")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Selecione o nome do projeto.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Selecione a concessionaria.")]
        public string Concessionaria { get; set; }
        [Required(ErrorMessage = "Digite a localidade do projeto.")]
        public string Localidade { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string Engenheiros { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string Situacao { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string ART { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string Protocolo { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string Observacao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
