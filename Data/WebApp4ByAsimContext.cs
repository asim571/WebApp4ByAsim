using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp4ByAsim.Models;

namespace WebApp4ByAsim.Data
{
    public class WebApp4ByAsimContext : DbContext
    {
        public WebApp4ByAsimContext (DbContextOptions<WebApp4ByAsimContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp4ByAsim.Models.Student> Student { get; set; } = default!;
    }
}
