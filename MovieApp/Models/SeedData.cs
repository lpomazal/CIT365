using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-11-9"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 14.99M,
                        ImageName = "SaratovApproach.jpeg"
                    },

                    new Movie
                    {
                        Title = "His Name Is Green Flake",
                        ReleaseDate = DateTime.Parse("2021-11-5"),
                        Genre = "Drama",
                        Rating = "NR",
                        Price = 14.99M,
                        ImageName = "HisNameIsGreenFlake.jpeg"
                    },

                    new Movie
                    {
                        Title = "Saints and Soliders",
                        ReleaseDate = DateTime.Parse("2003-3-25"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M,
                        ImageName = "SaintsSoldiers.jpeg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Biography",
                        Rating = "PG",
                        Price = 9.99M,
                        ImageName = "otherSide.jpeg"
                    },

                    new Movie
                    {
                        Title = "Jane and Emma",
                        ReleaseDate = DateTime.Parse("2018-11-12"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 12.99M,
                        ImageName = "JandAndEmma.jpeg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
