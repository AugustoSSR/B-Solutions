using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface IUsuariosRepositorio
    {
        UsuariosModel BuscarPorEmail(string email, string login);
        UsuariosModel BuscarPorLogin(string login);
        List<UsuariosModel> GetUsuario();
        UsuariosModel ListarPorID(int id);
        UsuariosModel Adicionar(UsuariosModel usuario);
        UsuariosModel Atualizar(UsuariosModel usuario);
        UsuariosModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);


        bool Apagar(int id);

    }
}
