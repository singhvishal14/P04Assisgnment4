using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAssisgn.Models;

namespace WebAppAssisgn.Data
{
    public class WebAppAssisgnDbContext : DbContext
    {
        public WebAppAssisgnDbContext (DbContextOptions<WebAppAssisgnDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAssisgn.Models.Student> Student { get; set; } = default!;
    }
}
