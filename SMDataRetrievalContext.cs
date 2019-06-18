using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SMDataRetrieval.Models
{
    public class SMDataRetrievalContext : DbContext
    {
		public SMDataRetrievalContext (DbContextOptions<SMDataRetrievalContext> options)
			: base(options)
		{
		}

		public DbSet<SMDataRetrieval.Models.CityNames> CityNames { get; set; }
		public DbSet<SMDataRetrieval.Models.country> country { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.HasDefaultSchema("world");
		}
    }
}
