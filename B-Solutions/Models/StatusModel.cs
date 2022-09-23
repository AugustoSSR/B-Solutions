using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class StatusModel
    {
        public int statusId { get; set; }
        [Required(ErrorMessage = "Informe por favor o nome do status do projeto")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "O nome deve conter de 2 a 25 caracteres.")]
        public string statusNome { get; set; }
        public DateTime statusDataCadastro { get; set; }
        public DateTime? statusDataAlteracao { get; set; }
    }
}
