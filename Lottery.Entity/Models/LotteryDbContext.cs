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
            modelBuilder.Entity<Sample>().HasData(
                new Sample() { Id = 1, Name = "類別A", Sort = 0, CreateDatetime=DateTime.Now },
                new Sample() { Id = 2, Name = "類別B", Sort = 1, CreateDatetime = DateTime.Now },
                new Sample() { Id = 3, Name = "類別C", Sort = 2, CreateDatetime = DateTime.Now }
                );

            //Can add constraint, index, check, data type, and even data seed
        }

        public DbSet<Sample> Sample { get; set; }
    }
}
