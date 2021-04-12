using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using RestApiInmoto.Model.Domain;

namespace RestApiInmoto.DAL.Config
{
    public class ArvenaDbContext : DbContext
    {
        protected readonly ICustomConfig _customConfig;

        public ArvenaDbContext(ICustomConfig customConfig) : base()
        {
            _customConfig = customConfig;
        }

        public DbSet<Sklep> Sklep { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_customConfig.ConnectionString);
            }
        }
    }
}
