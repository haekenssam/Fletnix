using Fletnix.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.Repositories
{
    public class FletnixContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Userprofile> Userprofiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DWDB007\\SYNTRA;Database=Fletnix.Db;User Id= Syntra; Password= Syntra123!");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
