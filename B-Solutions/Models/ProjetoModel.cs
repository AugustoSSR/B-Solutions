using B_Solutions.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class ProjetoModel
    {
        public int IdProjeto { get; set; }
        [Required(ErrorMessage = "Selecione o nome do projeto.")]
        public string projetoNome { get; set; }
        [Required(ErrorMessage = "Selecione a empresa do projeto.")]
        public string projetoEmpresa { get; set; }
        public int idProjetoEmpresa { get; set; }
        [Required(ErrorMessage = "Selecione o tipo do projeto.")]
        public string projetoTipo { get; set; }
        public int idProjetoTipo { get; set; }
        [Required(ErrorMessage = "Selecione a concessionaria.")]
        public string projetoConcessionaria { get; set; }
        public int idProjetoConcessionaria { get; set; }
        [Required(ErrorMessage = "Digite a localidade do projeto.")]
        public string projetoLocalidade { get; set; }
        public string? projetoEngenheiro { get; set; }
        [Required(ErrorMessage = "Selecione o status do projeto.")]
        public string projetoStatus { get; set; }
        public int idProjetoStatus { get; set; }
        public string? projetoART { get; set; }
        public string? projetoProtocolo { get; set; }
        public string? projetoObservacao { get; set; }
        public DateTime projetoDataCadastro { get; set; }
        public DateTime? projetoDataAlteracao { get; set; }
    }
}
