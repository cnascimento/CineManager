using CineManager.Domain;
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

        public CineManagerContext()
        {
            var client = new MongoClient("mongodb://root:printwayy@mongo");
            if (client != null)
                _database = client.GetDatabase("cinemanager_db");
        }

        public IMongoCollection<Movie> Movies
        {
            get
            {
                return _database.GetCollection<Movie>("Movie");
            }
        }
    }
}
