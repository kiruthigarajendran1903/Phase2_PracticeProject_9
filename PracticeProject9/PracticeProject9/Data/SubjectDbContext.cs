using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject9.Models;

namespace PracticeProject9.Data
{
    public class SubjectDbContext : DbContext
    {
        public SubjectDbContext (DbContextOptions<SubjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProject9.Models.Subject> Subject { get; set; } = default!;
    }
}
