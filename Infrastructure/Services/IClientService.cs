using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IClientService : IService
    {
        Task<IEnumerable<Client>> GetAllClient();
        Task CreateClient(string email, string password, string name, string lastname);
        Task DeleteClient(string email);
        Task<Client> GetClientByEmail(string email);
    }
}
