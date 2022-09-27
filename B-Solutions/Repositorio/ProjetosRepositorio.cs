using B_Solutions.Data;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;

namespace B_Solutions.Repositorio
{
    public class ProjetosRepositorio : IProjetosRepositorio
    {
        private readonly DataContext _bancoContext;
        public ProjetosRepositorio(DataContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ProjetoModel ListarPorID(int id)
        {
            return _bancoContext.Projetos.FirstOrDefault(x => x.IdProjeto == id);
        }
        public List<ProjetoModel> GetProjetos()
        {
            // listagem de projetos
            return _bancoContext.Projetos.ToList();
        }
        public ProjetoModel Adicionar(ProjetoModel projeto)
        {
            // Inserção do banco de dados.
            projeto.projetoDataCadastro = DateTime.Now;
            _bancoContext.Projetos.Add(projeto);
            _bancoContext.SaveChanges();
            return projeto;
        }

        public ProjetoModel Atualizar(ProjetoModel projeto)
        {
            ProjetoModel projetoDB = ListarPorID(projeto.IdProjeto);
            if (projetoDB == null) throw new System.Exception("Houve um erro na atualização do projeto.");
            projetoDB.projetoNome = projeto.projetoNome;
            projetoDB.projetoConcessionaria = projeto.projetoConcessionaria;
            projetoDB.projetoObservacao = projeto.projetoObservacao;
            projetoDB.projetoART = projeto.projetoART;
            projetoDB.projetoEngenheiro = projeto.projetoEngenheiro;
            projetoDB.projetoEmpresa = projeto.projetoEmpresa;
            projetoDB.projetoProtocolo = projeto.projetoProtocolo;
            projetoDB.projetoLocalidade = projeto.projetoLocalidade;
            projetoDB.projetoStatus = projeto.projetoStatus;
            projetoDB.projetoTipo = projeto.projetoTipo;
            projetoDB.projetoDataAlteracao = DateTime.Now;

            _bancoContext.Projetos.Update(projetoDB);
            _bancoContext.SaveChanges();

            return projetoDB;
        }

        public bool Apagar(int id)
        {
            ProjetoModel projetoDB = ListarPorID(id);

            if (projetoDB == null) throw new System.Exception("Houve um erro na deleção do projeto.");

            _bancoContext.Projetos.Remove(projetoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
