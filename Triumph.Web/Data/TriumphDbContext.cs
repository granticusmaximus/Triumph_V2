using System;
using Microsoft.EntityFrameworkCore;
using Triumph.Web.Entities;

namespace Triumph.Web.Data
{
    public class TriumphDbContext : DbContext
    {
        public TriumphDbContext(DbContextOptions<TriumphDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
