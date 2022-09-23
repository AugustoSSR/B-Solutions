using B_Solutions.Data;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;

namespace B_Solutions.Repositorio
{
    public class ArquivoRepositorio : IArquivoRepositorio
    {
        private readonly DataContext _dataContext;
        public ArquivoRepositorio(DataContext bancoContext)
        {
            _dataContext = bancoContext;
        }
        public ArquivosModel ListarPorID(int id)
        {
            return _dataContext.Arquivos.FirstOrDefault(x => x.arquivoId == id);
        }
        public List<ArquivosModel> GetArquivos()
        {
            // listagem de Arquivoss
            return _dataContext.Arquivos.ToList();
        }
        public ArquivosModel Adicionar(ArquivosModel Arquivos)
        {
            // Inserção do banco de dados.
            Arquivos.arquivoDataCadastro = DateTime.Now;
            _dataContext.Arquivos.Add(Arquivos);
            _dataContext.SaveChanges();
            return Arquivos;
        }

        public ArquivosModel Atualizar(ArquivosModel Arquivos)
        {
            ArquivosModel ArquivosDB = ListarPorID(Arquivos.arquivoId);
            if (ArquivosDB == null) throw new System.Exception("Houve um erro na atualização do Arquivos.");
            ArquivosDB.arquivoNome = Arquivos.arquivoNome;
            ArquivosDB.arquivoCaderno = Arquivos.arquivoCaderno;
            ArquivosDB.arquivoEmpresa = Arquivos.arquivoEmpresa;
            ArquivosDB.arquivoCaixa = Arquivos.arquivoCaixa;
            ArquivosDB.arquivoLocalidade = Arquivos.arquivoLocalidade;
            ArquivosDB.arquivoDataAlteracao = DateTime.Now;

            _dataContext.Arquivos.Update(ArquivosDB);
            _dataContext.SaveChanges();

            return ArquivosDB;
        }

        public bool Apagar(int id)
        {
            ArquivosModel ArquivosDB = ListarPorID(id);

            if (ArquivosDB == null) throw new System.Exception("Houve um erro na deleção do Arquivos.");

            _dataContext.Arquivos.Remove(ArquivosDB);
            _dataContext.SaveChanges();

            return true;
        }
    }
}
