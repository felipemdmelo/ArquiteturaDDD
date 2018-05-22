using DDDArquitetura.Domain.Entities;
using System.Collections.Generic;

namespace DDDArquitetura.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
