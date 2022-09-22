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
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }
        public UsuariosModel BuscarPorEmail(string email, string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper() && x.Login.ToUpper() == login.ToUpper());
        }
        public UsuariosModel ListarPorID(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuariosModel> GetUsuario()
        {
            // listagem de projetos
            return _bancoContext.Usuarios.ToList();
        }
        public UsuariosModel Adicionar(UsuariosModel usuario)
        {
            // Inserção do banco de dados.
            usuario.dataCadastro = DateTime.Now;
            usuario.SetSenhaHash();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuariosModel Atualizar(UsuariosModel usuario)
        {
            UsuariosModel usuarioDB = ListarPorID(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização do projeto.");
            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Telefone = usuario.Telefone;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.dataAlteracao = DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public UsuariosModel AlterarSenha(AlterarSenhaModel alterarSenhaModel)
        {
            UsuariosModel usuarioDB = ListarPorID(alterarSenhaModel.Id);
            if (usuarioDB == null) throw new Exception("Houve um erro na atualização da senha, usuário não encontrado.");
            if (!usuarioDB.SenhaValida(alterarSenhaModel.SenhaAtual)) throw new Exception("Senha atual não confere.");
            if (usuarioDB.SenhaValida(alterarSenhaModel.NovaSenha)) throw new Exception("Nova senha deve ser diferenda da senha atual");

            usuarioDB.SetNovaSenha(alterarSenhaModel.NovaSenha);
            usuarioDB.dataAlteracao = DateTime.Now;

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
