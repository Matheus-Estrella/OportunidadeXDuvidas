using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APIDuvidas.Data
{
    public class APIDuvidasContext : DbContext
    {
        public APIDuvidasContext (DbContextOptions<APIDuvidasContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Duvidas> Duvidas { get; set; } = default!;
    }
}
