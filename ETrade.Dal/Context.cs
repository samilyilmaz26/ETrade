using ETrade.Ent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dal
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{

		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>()
                .HasKey(o => new { o.OrderId, o.FoodId });
        }
        // DbSets
        public DbSet<Foods> Foods { get; set; }
		public DbSet<Categories> Categories { get; set; }
		public DbSet<OrderDetails> OrderDetails { get; set; }
		public DbSet<Orders> Orders { get; set; }
		public DbSet<Properties> Properties { get; set; }
        public DbSet<Test> Test { get; set; }

        public DbSet<Users> Users { get; set; }
	}
}
