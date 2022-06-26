using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebFilmes.Models;

    public class MvcFilmeContext : DbContext
    {
        public MvcFilmeContext (DbContextOptions<MvcFilmeContext> options)
            : base(options)
        {
        }

        public DbSet<WebFilmes.Models.Filme>? Filme { get; set; }
    }
