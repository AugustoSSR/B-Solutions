using B_Solutions.Enums;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome completo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuario.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuario.")]
        [EmailAddress(ErrorMessage = "O e-mail informando não é valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o telefone de contato")]
        [Phone(ErrorMessage = "O celular informado está errado")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe o cargo do usuario")]
        public PerfilEnum? Perfil { get; set; }

    }
}
