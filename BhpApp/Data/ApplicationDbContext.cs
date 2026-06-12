using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BhpApp.Models;

namespace BhpApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<Pracownik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Wypadek> Wypadki { get; set; }
    }
}