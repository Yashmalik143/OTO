using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OTO.Model
{
    public class StdDbContext:DbContext
    {
        public StdDbContext()
        {
        }

        public StdDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
