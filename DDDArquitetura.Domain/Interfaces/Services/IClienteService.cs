using DDDArquitetura.Domain.Entities;
using System.Collections.Generic;

namespace DDDArquitetura.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
