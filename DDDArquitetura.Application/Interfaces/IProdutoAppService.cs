using DDDArquitetura.Domain.Entities;
using System.Collections.Generic;

namespace DDDArquitetura.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
