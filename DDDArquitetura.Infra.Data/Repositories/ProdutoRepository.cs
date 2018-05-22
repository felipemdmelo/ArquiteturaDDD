using DDDArquitetura.Domain.Entities;
using DDDArquitetura.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DDDArquitetura.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
