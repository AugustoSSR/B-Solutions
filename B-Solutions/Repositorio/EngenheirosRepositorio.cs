using B_Solutions.Data;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;

namespace B_Solutions.Repositorio
{
    public class EngenheirosRepositorio : IEngenheirosRepositorio
    {
        private readonly DataContext _bancoContext;
        public EngenheirosRepositorio(DataContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EngenheirosModel ListarPorID(int id)
        {
            return _bancoContext.Engenheiros.FirstOrDefault(x => x.Id == id);
        }
        public List<EngenheirosModel> GetEngenheiros()
        {
            // listagem de Engenheiross
            return _bancoContext.Engenheiros.ToList();
        }
        public EngenheirosModel Adicionar(EngenheirosModel Engenheiros)
        {
            // Inserção do banco de dados.
            Engenheiros.dataCadastro = DateTime.Now;
            _bancoContext.Engenheiros.Add(Engenheiros);
            _bancoContext.SaveChanges();
            return Engenheiros;
        }

        public EngenheirosModel Atualizar(EngenheirosModel Engenheiros)
        {
            EngenheirosModel EngenheirosDB = ListarPorID(Engenheiros.Id);
            if (EngenheirosDB == null) throw new System.Exception("Houve um erro na atualização do Engenheiros.");
            EngenheirosDB.Nome = Engenheiros.Nome;
            EngenheirosDB.CPF = Engenheiros.CPF;
            EngenheirosDB.CREA = Engenheiros.CREA;
            EngenheirosDB.Email = Engenheiros.Email;
            EngenheirosDB.dataAlteracao = DateTime.Now;

            _bancoContext.Engenheiros.Update(EngenheirosDB);
            _bancoContext.SaveChanges();

            return EngenheirosDB;
        }

        public bool Apagar(int id)
        {
            EngenheirosModel EngenheirosDB = ListarPorID(id);

            if (EngenheirosDB == null) throw new System.Exception("Houve um erro na deleção do Engenheiros.");

            _bancoContext.Engenheiros.Remove(EngenheirosDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
