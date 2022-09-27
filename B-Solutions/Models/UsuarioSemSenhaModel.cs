using B_Solutions.Enums;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class UsuarioSemSenhaModel
    {
        public int idUsuarioSemSenha { get; set; }
        [Required(ErrorMessage = "Digite o nome completo.")]
        public string usuarioSemSenhaNome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuario.")]
        public string usuarioSemSenhaLogin { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuario.")]
        [EmailAddress(ErrorMessage = "O e-mail informando não é valido.")]
        public string usuarioSemSenhaEmail { get; set; }
        [Required(ErrorMessage = "Digite o telefone de contato")]
        [Phone(ErrorMessage = "O celular informado está errado")]
        public string usuarioSemSenhaTelefone { get; set; }
        [Required(ErrorMessage = "Informe o cargo do usuario")]
        public string usuarioSemSenhaCargo { get; set; }
        public int usuarioSemSenhaCargoId { get; set; }

    }
}
