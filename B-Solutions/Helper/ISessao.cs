using B_Solutions.Models;

namespace B_Solutions.Helper
{
    public interface ISessao
    {
        void criarSessaoUsuario(UsuariosModel usuariosModel);
        void removerSessaoUsuario();
        UsuariosModel BuscarSessaoUsuario();
    }
}
