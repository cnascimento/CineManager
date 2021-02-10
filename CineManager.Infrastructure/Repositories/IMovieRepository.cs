using CineManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineManager.Infrastructure.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> GetAsync(int MovieId);

        Task<List<Movie>> GetListAsync();
    }
}
