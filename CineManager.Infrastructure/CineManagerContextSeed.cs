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
    public class CineManagerContextSeed
    {
        private static CineManagerContext ctx;

        public static async Task SeedAsync(IOptions<CineManagerSettings> settings)
        {
            ctx = new CineManagerContext(settings);

            if (!ctx.Users.Database.GetCollection<User>(nameof(User)).AsQueryable().Any())
            {
                await SetUsers();
            }
        }

        static async Task SetUsers()
        {
            var user = new User()
            {
                UserId = 1,
                Name = "Cristiano do Nascimento",
                Email = "cristiano.n@gmail.com",
                Password = "102030xyz"
            };
            await ctx.Users.InsertOneAsync(user);
        }
    }
}
