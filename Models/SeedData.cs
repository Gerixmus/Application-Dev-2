using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Data.MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Skyfall",
                        ReleaseDate=DateTime.Parse("2017-11-21"),
                        Genre = "Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Title = "Listy do M",
                        ReleaseDate = DateTime.Parse("2015-12-10"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "Untouchables",
                        ReleaseDate = DateTime.Parse("2011-05-13"),
                        Genre = "Comedy Drama",
                        Price = 12
                    },
                    new Movie
                    {
                        Title = "Spiderman",
                        ReleaseDate = DateTime.Parse("2019-09-23"),
                        Genre = "Action",
                        Price = 6
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
