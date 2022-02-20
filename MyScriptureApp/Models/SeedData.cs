using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureApp.Data;
using System;
using System.Linq;

namespace MyScriptureApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureAppContext>>()))
            {
                // Look for any movies.
                if (context.Entry.Any())
                {
                    return;   // DB has been seeded
                }

                context.Entry.AddRange(
                    new Entry
                    {
                        Book = "John",
                        Chapter = "20",
                        Verse = 17,
                        EntryDate = DateTime.Parse("2021-11-28"),
                        Thoughts = "Jesus appeared to Mary before all she calls him Rabboni and he calls her to testify. Mary an Appostle?"
                    },

                    new Entry
                    {
                        Book = "Genesis",
                        Chapter = "2",
                        Verse = 18,
                        EntryDate = DateTime.Parse("2019-09-15"),
                        Thoughts = "an help meet... translation is poor ezer meaning power of God, proctector, and rescuer. Eve didn't come to help she came to Save"
                    },

                    new Entry
                    {
                        Book = "Mosiah",
                        Chapter = "18",
                        Verse = 9,
                        EntryDate = DateTime.Parse("2018-05-28"),
                        Thoughts = "We are called not to dismiss but to mourn, to love and to comfort"
                    },

                    new Entry
                    {
                        Book = "Genesis",
                        Chapter = "19",
                        Verse = 9,
                        EntryDate = DateTime.Parse("2022-02-15"),
                        Thoughts = "Lot's wife has a name...Ado or Edith. Was her sin a look? Lack of faith? Lust for sin? Not enough context"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}