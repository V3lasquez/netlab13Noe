using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netlab13Noe.Models;

namespace netlab13Noe.Data
{
    public class netlab13NoeContext : DbContext
    {
        public netlab13NoeContext (DbContextOptions<netlab13NoeContext> options)
            : base(options)
        {
        }

        public DbSet<netlab13Noe.Models.Customer> Customer { get; set; } = default!;
    }
}
