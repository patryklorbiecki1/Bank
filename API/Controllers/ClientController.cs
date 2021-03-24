using Domain;
using Infrastructure.Commands;
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
       // private readonly ICommandDispatcher _commandHandler;
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService,ICommandDispatcher commandHandler)
        {
        //    _commandHandler = commandHandler;
            _clientService = clientService;
        }

        [HttpGet("/client")]
        public async Task<IEnumerable<Client>> GetClients()
         => await _clientService.GetAllClient();

    }
}
