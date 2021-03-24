using Domain;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Task CreateClient()
        {
           throw new NotImplementedException();
        }

        public async Task<IEnumerable<Client>> GetAllClient()
        =>  await _clientRepository.GetAll();
        
    }
}
