using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using uamis_isfulford3.Models;

namespace uamis_isfulford3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<uamis_isfulford3.Models.Actor> Actor { get; set; }
        public DbSet<uamis_isfulford3.Models.Movie> Movie { get; set; }
    }
}