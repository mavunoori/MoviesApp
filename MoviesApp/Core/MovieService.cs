using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Core
{
    public class MovieService : IMovieService
    {
        public IList<Movie> GetMovies()
        {
            return new List<Movie>()
                {
                new Movie{ ID=1,Name="Movie1"},
                new Movie { ID = 2, Name = "Movie2" },
                new Movie { ID = 3, Name = "Movie3" },
                new Movie { ID = 4, Name = "Movie4" }
            };
        }
    }
}
