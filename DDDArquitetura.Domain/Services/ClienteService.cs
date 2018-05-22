using DDDArquitetura.Domain.Entities;
using DDDArquitetura.Domain.Interfaces.Services;
using DDDArquitetura.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDArquitetura.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.IsClienteEspecial());
        }
    }
}
