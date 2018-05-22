using DDDArquitetura.Domain.Entities;
using DDDArquitetura.Domain.Interfaces.Repositories;

namespace DDDArquitetura.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
