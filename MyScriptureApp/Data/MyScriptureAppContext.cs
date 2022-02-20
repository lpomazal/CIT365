using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureApp.Models;

namespace MyScriptureApp.Data
{
    public class MyScriptureAppContext : DbContext
    {
        public MyScriptureAppContext (DbContextOptions<MyScriptureAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureApp.Models.Entry> Entry { get; set; }
    }
}
