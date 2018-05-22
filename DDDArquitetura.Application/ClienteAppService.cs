using DDDArquitetura.Application.Interfaces;
using DDDArquitetura.Domain.Entities;
using System.Collections.Generic;
using DDDArquitetura.Domain.Interfaces.Services;

namespace DDDArquitetura.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
