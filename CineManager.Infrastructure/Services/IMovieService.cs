using CineManager.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CineManager.Infrastructure.Services
{
    public interface IMovieService
    {
        Task<Movie> GetAsync(int movieId);

        Task<List<Movie>> GetAllAsync();
    }
}
