using B_Solutions.Data;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;

namespace B_Solutions.Repositorio
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private readonly DataContext _bancoContext;
        public UsuariosRepositorio(DataContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuariosModel BuscarPorLogin(string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.usuarioLogin.ToUpper() == login.ToUpper());
        }
        public UsuariosModel BuscarPorEmail(string email, string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.usuarioEmail.ToUpper() == email.ToUpper() && x.usuarioLogin.ToUpper() == login.ToUpper());
        }
        public UsuariosModel ListarPorID(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
        }
        public List<UsuariosModel> GetUsuario()
        {
            // listagem de projetos
            return _bancoContext.Usuarios.ToList();
        }
        public UsuariosModel Adicionar(UsuariosModel usuario)
        {
            // Inserção do banco de dados.
            usuario.usuarioDataCadastro = DateTime.Now;
            usuario.SetSenhaHash();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuariosModel Atualizar(UsuariosModel usuario)
        {
            UsuariosModel usuarioDB = ListarPorID(usuario.IdUsuario);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização do projeto.");
            usuarioDB.usuarioNome = usuario.usuarioNome;
            usuarioDB.usuarioLogin = usuario.usuarioLogin;
            usuarioDB.usuarioEmail = usuario.usuarioEmail;
            usuarioDB.usuarioTelefone = usuario.usuarioTelefone;
            usuarioDB.usuarioCargo = usuario.usuarioCargo;
            usuarioDB.usuarioDataAlteracao = DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public UsuariosModel AlterarSenha(AlterarSenhaModel alterarSenhaModel)
        {
            UsuariosModel usuarioDB = ListarPorID(alterarSenhaModel.alterarId);
            if (usuarioDB == null) throw new Exception("Houve um erro na atualização da senha, usuário não encontrado.");
            if (!usuarioDB.SenhaValida(alterarSenhaModel.alterarSenhaAtual)) throw new Exception("Senha atual não confere.");
            if (usuarioDB.SenhaValida(alterarSenhaModel.alterarSenhaNova)) throw new Exception("Nova senha deve ser diferenda da senha atual");

            usuarioDB.SetNovaSenha(alterarSenhaModel.alterarSenhaNova);
            usuarioDB.usuarioDataAlteracao = DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            UsuariosModel usuarioDB = ListarPorID(id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na deleção do projeto.");

            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
