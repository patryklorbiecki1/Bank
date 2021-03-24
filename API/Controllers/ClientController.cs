using Domain;
using Infrastructure.Commands;
using Infrastructure.Commands.User;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ICommandDispatcher _commandHandler;
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService,ICommandDispatcher commandHandler)
        {
            _commandHandler = commandHandler;
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IEnumerable<Client>> GetAllClients()
         => await _clientService.GetAllClient();

        [HttpGet("{email}")]
        public async Task<Client> GetClientByEmail(string email)
             => await _clientService.GetClientByEmail(email);

        [HttpPost]
        public async Task CreateUser([FromBody] CreateClient user)
        {
            await _commandHandler.DispatchAsync(user);
        }
        [HttpDelete]
        public async Task DeleteUser(string email)
        {
            await _clientService.DeleteClient(email);
        }
        
    }
}
