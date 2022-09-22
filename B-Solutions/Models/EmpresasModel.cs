using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace B_Solutions.Models
{
    public class EmpresasModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Test")]
        public string Nome { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        public string Razao { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
