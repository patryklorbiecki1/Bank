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
        Task CreateClient();
    }
}
