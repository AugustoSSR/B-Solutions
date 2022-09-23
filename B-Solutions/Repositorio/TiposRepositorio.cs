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
        public TiposModel ListarPorID(int id)
        {
            return _bancoContext.Tipos.FirstOrDefault(x => x.idTipo == id);
        }
        public List<TiposModel> GetTipos()
        {
            // listagem de Arquivoss
            return _bancoContext.Tipos.ToList();
        }
        public TiposModel Adicionar(TiposModel tipos)
        {
            // Inserção do banco de dados.
            tipos.dataCadastro = DateTime.Now;
            _bancoContext.Tipos.Add(tipos);
            _bancoContext.SaveChanges();
            return tipos;
        }

        public TiposModel Atualizar(TiposModel tipos)
        {
            TiposModel tiposDB = ListarPorID(tipos.idTipo);
            if (tiposDB == null) throw new System.Exception("Houve um erro na atualização do Arquivos.");
            tiposDB.Nome = tipos.Nome;
            tiposDB.IsActive = tipos.IsActive;
            tiposDB.dataAlteracao = DateTime.Now;

            _bancoContext.Tipos.Update(tiposDB);
            _bancoContext.SaveChanges();

            return tiposDB;
        }

        public bool Apagar(int id)
        {
            TiposModel tiposDB = ListarPorID(id);

            if (tiposDB == null) throw new System.Exception("Houve um erro na deleção do Arquivos.");

            _bancoContext.Tipos.Remove(tiposDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
