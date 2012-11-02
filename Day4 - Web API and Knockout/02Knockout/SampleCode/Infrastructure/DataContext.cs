using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SampleCode.Models;

namespace SampleCode.Infrastructure
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }


        public IDbSet<Movie> Movies { get; set; }
    }


    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="The Hobbit", Director="Jackson"},
                new Movie {Title="Memento", Director="Nolan"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        }

    }

}