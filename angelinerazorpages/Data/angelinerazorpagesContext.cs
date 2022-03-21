#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using angelinerazorpages.Pages.preaching;

namespace angelinerazorpages.Data
{
    public class angelinerazorpagesContext : DbContext
    {
        public angelinerazorpagesContext (DbContextOptions<angelinerazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<angelinerazorpages.Pages.preaching.Class> Class { get; set; }
    }
}
