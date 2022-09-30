using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Entities.Models
{
    public class LotteryDbContext: DbContext
    {
        public LotteryDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasData(
            //    new Category() { Id = 1, Name = "類別A", DisplayOrder = 0 },
            //    new Category() { Id = 2, Name = "類別B", DisplayOrder = 1 },
            //    new Category() { Id = 3, Name = "類別C", DisplayOrder = 2 }
            //    );

            //Can add constraint, index, check, data type, and even data seed
        }

        public DbSet<Sample> Sample { get; set; }
    }
}
