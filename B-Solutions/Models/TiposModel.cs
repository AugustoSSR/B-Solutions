using System.ComponentModel.DataAnnotations;
namespace B_Solutions.Models
{
    public class TiposModel
    {
        [Display(Name = "Identificação")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Coloque o nome do tipo")]
        public string Nome { get; set; }
        [Display(Name = "Ativo")]
        public bool? IsActive { get; set; }
        [Display(Name = "Data de cadastro")]
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
