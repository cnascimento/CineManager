using CineManager.Domain;
using CineManager.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CineManager.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Task<List<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> GetAsync(int movieId)
        {
            return await _movieRepository.GetAsync(movieId);
        }
    }
}
