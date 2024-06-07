using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API_Oportunidades.Data
{
    public class API_OportunidadesContext : DbContext
    {
        public API_OportunidadesContext (DbContextOptions<API_OportunidadesContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Oportunidade> Oportunidade { get; set; } = default!;
    }
}
