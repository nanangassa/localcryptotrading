using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocalCrytoTrading.Models;

namespace RazorPagesUser.Data
{
    public class RazorPagesUserContext : DbContext
    {
        public RazorPagesUserContext (DbContextOptions<RazorPagesUserContext> options)
            : base(options)
        {
        }

        public DbSet<LocalCrytoTrading.Models.User> User { get; set; }
    }
}
