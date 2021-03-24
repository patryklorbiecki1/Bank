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

        public Client(string email, string password,string name,string lastname)
        {
            Email = email;
            Password = password;
            Name = name;
            LastName = lastname;
            IdentityNumber = Guid.NewGuid();
            Amount = 0;
            var random = new Random();
            AccountNumber = string.Empty;
            for (int i = 0; i < 26; i++)
                AccountNumber = String.Concat(AccountNumber, random.Next(10).ToString());
        }
       
    }
}
