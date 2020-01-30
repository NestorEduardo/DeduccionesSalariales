using DeduccionesSalariales.Models;
using Microsoft.EntityFrameworkCore;

namespace DeduccionesSalariales.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Deduction> Deductions { get; set; }
    }
}
