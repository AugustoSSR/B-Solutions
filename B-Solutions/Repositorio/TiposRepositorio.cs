using B_Solutions.Data;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;

namespace B_Solutions.Repositorio
{
    public class TiposRepositorio : ITiposRepositorio
    {
        private readonly DataContext _bancoContext;
        public TiposRepositorio(DataContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public TipoProjetoModel ListarPorID(int id)
        {
            return _bancoContext.Tipos.FirstOrDefault(x => x.IdProjetoTipo == id);
        }
        public List<TipoProjetoModel> GetTipos()
        {
            // listagem de Arquivoss
            return _bancoContext.Tipos.ToList();
        }
        public TipoProjetoModel Adicionar(TipoProjetoModel tipos)
        {
            // Inserção do banco de dados.
            tipos.tipoProjetoDataCadastro = DateTime.Now;
            _bancoContext.Tipos.Add(tipos);
            _bancoContext.SaveChanges();
            return tipos;
        }

        public TipoProjetoModel Atualizar(TipoProjetoModel tipos)
        {
            TipoProjetoModel tiposDB = ListarPorID(tipos.IdProjetoTipo);
            if (tiposDB == null) throw new System.Exception("Houve um erro ao tentar atualizar o tipo do projeto, tente novamente.");
            tiposDB.tipoProjetoNome = tipos.tipoProjetoNome;
            tiposDB.tipoProjetoDataAlteracao = DateTime.Now;

            _bancoContext.Tipos.Update(tiposDB);
            _bancoContext.SaveChanges();

            return tiposDB;
        }

        public bool Apagar(int id)
        {
            TipoProjetoModel tiposDB = ListarPorID(id);

            if (tiposDB == null) throw new System.Exception("Houve um erro ao tentar apagar o tipo do projeto, tente novamente.");

            _bancoContext.Tipos.Remove(tiposDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
