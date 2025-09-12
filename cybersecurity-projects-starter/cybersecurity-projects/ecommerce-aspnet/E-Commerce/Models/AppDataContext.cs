using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Models
{
    public class AppDataContext : IdentityDbContext<AppUser>

    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)

        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
