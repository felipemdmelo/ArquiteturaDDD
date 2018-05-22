using DDDArquitetura.Domain.Entities;
using System.Collections.Generic;

namespace DDDArquitetura.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
