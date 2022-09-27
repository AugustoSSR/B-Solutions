using B_Solutions.Enums;
using B_Solutions.Helper;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class UsuariosModel
    {
        public int IdUsuario { get; set; }
        
        [Required(ErrorMessage = "Digite o nome completo.")]
        public string usuarioNome { get; set; }

        [Required(ErrorMessage = "Digite o login do usuario.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "O nome de usuario deve conter entre 5 e 10 caracteres.")]
        public string usuarioLogin { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do usuario.")]
        [EmailAddress(ErrorMessage = "O e-mail informando não é valido.")]
        public string usuarioEmail { get; set; }

        [Required(ErrorMessage = "Digite o telefone de contato")]
        [Phone(ErrorMessage = "O celular informado está errado")]
        public string usuarioTelefone { get; set; }

        [Required(ErrorMessage = "Digite sua senha por favor.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "A senha do usuario deve conter entre 8 e 16 caracteres.")]
        public string usuarioSenha { get; set; }

        [Required(ErrorMessage = "Informe o cargo do usuario")]
        public string? usuarioCargo { get; set; }
        public int? usuarioIdCargo { get; set; }
        public DateTime usuarioDataCadastro { get; set; }
        public DateTime? usuarioDataAlteracao { get; set; }

        public bool SenhaValida(string senha)
        {
            return usuarioSenha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            usuarioSenha = usuarioSenha.GerarHash();
        }
        public void SetNovaSenha(string novaSenha)
        {
            usuarioSenha = novaSenha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            // gerar nova senha com hash sha1.
            string novaSenha = Guid.NewGuid().ToString().Substring(0 , 8);
            usuarioSenha = novaSenha.GerarHash();
            return novaSenha;
        }

    }
}
