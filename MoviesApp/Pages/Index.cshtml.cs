using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MoviesApp.Core;

namespace MoviesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMovieService movieService;

        public IndexModel(IMovieService movieService)
        {
            this.movieService = movieService;
        }

       public IList<Movie> Movies;
        public void OnGet()
        {
            Movies = movieService.GetMovies();
        }
    }
}
