using CineManager.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineManager.Infrastructure
{
    public class CineManagerContext
    {
        private readonly IMongoDatabase _database = null;

        public CineManagerContext(IOptions<CineManagerSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<Movie> Movies
        {
            get { return _database.GetCollection<Movie>("movies"); }
        }

        public IMongoCollection<Room> Rooms
        {
            get { return _database.GetCollection<Room>("rooms"); }
        }

        public IMongoCollection<User> Users
        {
            get { return _database.GetCollection<User>("users"); }
        }
    }
}
