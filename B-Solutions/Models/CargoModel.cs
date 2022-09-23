using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class CargoModel
    {
        public int cargoId { get; set; }
        [Required(ErrorMessage = "Coloque o nome do cargo")]
        public string cargoNome { get; set; }
        public DateTime cargoDataCadastro { get; set; }
        public DateTime? cargoDataAlteraaco { get; set; }
    }
}
