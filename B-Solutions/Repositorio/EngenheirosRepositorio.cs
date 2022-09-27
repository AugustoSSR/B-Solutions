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
            return _bancoContext.Engenheiros.FirstOrDefault(x => x.IdEngenheiro == id);
        }
        public List<EngenheirosModel> GetEngenheiros()
        {
            // listagem de Engenheiross
            return _bancoContext.Engenheiros.ToList();
        }
        public EngenheirosModel Adicionar(EngenheirosModel engenheiros)
        {
            // Inserção do banco de dados.
            engenheiros.engenheiroDataCadastro = DateTime.Now;
            _bancoContext.Engenheiros.Add(engenheiros);
            _bancoContext.SaveChanges();
            return engenheiros;
        }

        public EngenheirosModel Atualizar(EngenheirosModel engenheiros)
        {
            EngenheirosModel engenheirosDB = ListarPorID(engenheiros.IdEngenheiro);
            if (engenheirosDB == null) throw new System.Exception("Houve um erro na atualização do Engenheiros.");
            engenheirosDB.engenheiroNome = engenheiros.engenheiroNome;
            engenheirosDB.engenheiroCPF = engenheiros.engenheiroCPF;
            engenheirosDB.engenheiroCREA = engenheiros.engenheiroCREA;
            engenheirosDB.engenheiroEmail = engenheiros.engenheiroEmail;
            engenheirosDB.engenheiroDataAlteracao = DateTime.Now;

            _bancoContext.Engenheiros.Update(engenheirosDB);
            _bancoContext.SaveChanges();

            return engenheirosDB;
        }

        public bool Apagar(int id)
        {
            EngenheirosModel engenheirosDB = ListarPorID(id);

            if (engenheirosDB == null) throw new System.Exception("Houve um erro na deleção do Engenheiros.");

            _bancoContext.Engenheiros.Remove(engenheirosDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
