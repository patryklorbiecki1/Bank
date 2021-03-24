using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Commands.User
{
    public class CreateClient : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}
