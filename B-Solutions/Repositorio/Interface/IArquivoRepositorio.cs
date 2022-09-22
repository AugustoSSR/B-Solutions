using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface IArquivoRepositorio
    {
        List<ArquivosModel> GetArquivos();
        ArquivosModel ListarPorID(int id);
        ArquivosModel Adicionar(ArquivosModel arquivo);
        ArquivosModel Atualizar(ArquivosModel arquivo);

        bool Apagar(int id);

    }
}
