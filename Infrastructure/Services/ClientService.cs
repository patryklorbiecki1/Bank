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
        public async Task CreateClient(string email,string password,string name,string lastname)
        {
            await _clientRepository.AddClient(new Client(email, password, name, lastname));
        }

        public async Task DeleteClient(string email)
        {
            await _clientRepository.DeleteByEmail(email);
        }

        public async Task<IEnumerable<Client>> GetAllClient()
            => await _clientRepository.GetAll();

        public async Task<Client> GetClientByEmail(string email)
            => await _clientRepository.GetClient(email);
    }
}
