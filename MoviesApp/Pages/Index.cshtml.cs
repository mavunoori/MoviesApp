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
        //private readonly IMovieService movieService;

        //public IndexModel(IMovieService movieService)
        //{
        //    this.movieService = movieService;
        //}

        public IndexModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<Movie> Movies;
        private readonly ApplicationDbContext dbContext;

        public void OnGet()
        {
            Movies = dbContext.Movies.ToList();
        }
    }
}
