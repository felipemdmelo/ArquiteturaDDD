using DDDArquitetura.Domain.Entities;
using System.Collections.Generic;

namespace DDDArquitetura.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
