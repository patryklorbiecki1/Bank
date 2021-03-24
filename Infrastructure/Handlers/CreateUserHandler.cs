using Infrastructure.Commands;
using Infrastructure.Commands.User;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Handlers
{
    public class CreateClientHandler : ICommandHandler<CreateClient>
    {
        private readonly IClientService _clientService;
        public CreateClientHandler(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task HandleAsync(CreateClient command)
        {
            await _clientService.CreateClient(command.Email,command.Password,command.Name,command.Lastname);
        }
    }
}
