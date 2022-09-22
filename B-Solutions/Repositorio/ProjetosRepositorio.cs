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
            return _bancoContext.Projetos.FirstOrDefault(x => x.Id == id);
        }
        public List<ProjetoModel> GetProjetos()
        {
            // listagem de projetos
            return _bancoContext.Projetos.ToList();
        }
        public ProjetoModel Adicionar(ProjetoModel projeto)
        {
            // Inserção do banco de dados.
            projeto.dataCadastro = DateTime.Now;
            _bancoContext.Projetos.Add(projeto);
            _bancoContext.SaveChanges();
            return projeto;
        }

        public ProjetoModel Atualizar(ProjetoModel projeto)
        {
            ProjetoModel projetoDB = ListarPorID(projeto.Id);
            if (projetoDB == null) throw new System.Exception("Houve um erro na atualização do projeto.");
            projetoDB.Nome = projeto.Nome;
            projetoDB.Concessionaria = projeto.Concessionaria;
            projetoDB.Observacao = projeto.Observacao;
            projetoDB.ART = projeto.ART;
            projetoDB.Engenheiros = projeto.Engenheiros;
            projetoDB.Empresa = projeto.Empresa;
            projetoDB.Protocolo = projeto.Protocolo;
            projetoDB.Localidade = projeto.Localidade;
            projetoDB.Situacao = projeto.Situacao;
            projetoDB.Tipo = projeto.Tipo;
            projetoDB.dataAlteracao = DateTime.Now;

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
