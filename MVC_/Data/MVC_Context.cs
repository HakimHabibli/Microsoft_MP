using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_.Models;

namespace MVC_.Data
{
    public class MVC_Context : DbContext
    {
        public MVC_Context (DbContextOptions<MVC_Context> options)
            : base(options)
        {
        }

        public DbSet<MVC_.Models.Movie> Movie { get; set; } = default!;
    }
}
