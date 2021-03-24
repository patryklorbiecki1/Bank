using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Client
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public Guid IdentityNumber { get; protected set; }
        public decimal Amount { get; protected set; }
        public string AccountNumber { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
       
    }
}
