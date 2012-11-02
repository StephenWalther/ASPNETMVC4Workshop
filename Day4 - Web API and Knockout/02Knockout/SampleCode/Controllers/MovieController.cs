using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleCode.Infrastructure;
using SampleCode.Models;

namespace SampleCode.Controllers
{
    public class MovieController : ApiController
    {
        private DataContext _dataContext = new DataContext();

        // Invoke with HTTP GET
        public IEnumerable<Movie> GetMovies()
        {
            return _dataContext.Movies.ToList();
        }

        // Invoke with HTTP POST
        public HttpResponseMessage PostMovie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                // Save to database
                _dataContext.Movies.Add(newMovie);
                _dataContext.SaveChanges();

                // Return success response
                return new HttpResponseMessage<Movie>(newMovie, HttpStatusCode.Created);
            }

            // Return errors
            var errors = new List<string>();
            foreach (var prop in ModelState.Values)
            {
                if (prop.Errors.Any())
                {
                    errors.Add(prop.Errors.First().ErrorMessage);
                }
            }
            return new HttpResponseMessage<List<string>>(errors, HttpStatusCode.BadRequest);
        }

    }
}
