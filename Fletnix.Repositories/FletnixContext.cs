﻿using Fletnix.Model;
using Microsoft.EntityFrameworkCore;

namespace Fletnix.Repositories
{
    public class FletnixContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Fletnix.Db;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
