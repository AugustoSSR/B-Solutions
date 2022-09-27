using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace B_Solutions.Models
{
    public class EmpresasModel
    {
        public int IdEmpresa { get; set; }
        [Required(ErrorMessage = "Nome Fantasia - Por favor preencha este campo.")]
        public string empresaFantasia { get; set; }
        [Required(ErrorMessage = "Razão Sócial - Por favor preencha este campo.")]
        public string empresaRazao { get; set; }
        [Required(ErrorMessage = "CNPJ - Por favor preencha este campo.")]
        public string empresaCNPJ { get; set; }
        [Required(ErrorMessage = "Rua - Por favor preencha este campo.")]
        public string? empresaRua { get; set; }
        [Required(ErrorMessage = "Numero - Por favor preencha este campo.")]
        public string empresaRuaNumero { get; set; }
        [Required(ErrorMessage = "Bairro - Por favor preencha este campo.")]
        public string empresaRuaBairro { get; set; }
        [Required(ErrorMessage = "Cidade - Por favor preencha este campo.")]
        public string empresaRuaCidade { get; set; }
        [Required(ErrorMessage = "Estado - Por favor preencha este campo.")]
        public string empresaRuaEstado { get; set; }
        [Required(ErrorMessage = "Cep - Por favor preencha este campo.")]
        public string empresaRuaCep { get; set; }

        // Dados contato comercial para RGE
        public string? empresaComercialEmail { get; set; }
        public string? empresaComercialCPF { get; set; }
        public string? empresaComercialRG { get; set; }
        public string? empresaComercialNome { get; set; }
        public string? empresaComercialCargo { get; set; }

        // Dados contato responsavel para RGE
        public string? empresaResponsavelEmail { get; set; }
        public string? empresaResponsavelCPF { get; set; }
        public string? empresaResponsavelRG { get; set; }
        public string? empresaResponsavelNome { get; set; }
        public string? empresaResponsavelCargo { get; set; }

        [Phone(ErrorMessage = "Número de celular incorreto.")]
        public string? empresaTelefone { get; set; }

        // Registro de modificação e criação
        public DateTime? empresaDataCadastro { get; set; }
        public DateTime? empresaDataAlteracao { get; set; }
    }
}
