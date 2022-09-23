using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class ArquivosModel
    {
        public int arquivoId { get; set; }
        [Required(ErrorMessage = "Nome - Preencha com o nome do arquivo.")]
        public string arquivoNome { get; set; }
        [Required(ErrorMessage = "Caderno - Preencha com o numero do caderno, caso não haja caderno coloque 0")]
        public string arquivoCaderno { get; set; }
        [Required(ErrorMessage = "Caixa - Preencha com o numero da caixa, caso não haja caderno coloque 0")]
        public string arquivoCaixa { get; set; }
        [Required(ErrorMessage = "Empresa - Selecione o nome da empresa.")]
        public string arquivoEmpresa { get; set; }
        [Required(ErrorMessage = "Localidade - Preencha com o nome da localidade.")]
        public string arquivoLocalidade { get; set; }
        public DateTime arquivoDataCadastro { get; set; }
        public DateTime? arquivoDataAlteracao { get; set; }
    }
}
