using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models
{
    public class TourDbContext : DbContext
    {
        public TourDbContext (DbContextOptions<TourDbContext> options) : base(options)
        {

        }

        public DbSet<AvailableTime> AvailableTimes { get; set; }
        public DbSet<GroupInfo> GroupInfos { get; set; }
    }
}
