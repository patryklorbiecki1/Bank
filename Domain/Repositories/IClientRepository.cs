using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IClientRepository : IRepository
    {
        Task AddClient(Client client);
        Task<Client> GetClient(string email);
        Task DeleteByEmail(string email);
        Task<IEnumerable<Client>> GetAll();
        Task UpdateClient(Client client);
    }
}
