using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Core
{
    public interface IMovieService
    {
        IList<Movie> GetMovies();
    }
}
