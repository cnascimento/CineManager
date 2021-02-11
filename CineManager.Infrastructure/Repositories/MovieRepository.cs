using CineManager.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineManager.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CineManagerContext _context;

        public MovieRepository(IOptions<CineManagerSettings> settings)
        {
            _context = new CineManagerContext(settings);
        }

        public async Task<Movie> GetAsync(int MovieId)
        {
            //var movie = new Movie
            //{
            //    MovieId = 1,
            //    Duration = 180,
            //    Description = "Filme Teste",
            //    Image = "http://www.teste.com/image.jpg",
            //    Title = "Filme Teste"
            //};
            //await _context.Movies.InsertOneAsync(movie);

            var filter = Builders<Movie>.Filter.Eq("movie_id", MovieId);
            return await _context.Movies
                                 .Find(filter)
                                 .FirstOrDefaultAsync();
        }

        public Task<List<Movie>> GetListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
