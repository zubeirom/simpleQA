using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQa.Entities
{
    public class SimpleQaContext : DbContext
    {
        public SimpleQaContext(DbContextOptions<SimpleQaContext> options) : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        public DbSet<Question> Question { get; set; }
        public DbSet<Comment> Commnet { get; set; } 
    }
}