using Domain;
using Domain.Repositories;
using Infrastructure.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IMongoCollection<Client> _context;
        public ClientRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.Database);
            _context = database.GetCollection<Client>("Client");
        }
        public async Task AddClient(Client client)
        {
            _context.InsertOne(client);
            await Task.CompletedTask;
        }
        public async Task DeleteByEmail(string email)
        {
            await Task.FromResult(_context.DeleteOne(c => c.Email == email));
        }
        public async Task<IEnumerable<Client>> GetAll()
           => await Task.FromResult(_context.Find(client => true).ToList());

        public async Task<Client> GetClient(string email)
            => await Task.FromResult(_context.Find(c => c.Email == email).FirstOrDefault());

        public async Task UpdateClient(Client client)
            => await Task.FromResult(_context.FindOneAndReplace(c => c.Email == client.Email,client));
    }
}
