using Microsoft.EntityFrameworkCore;
using TheImperialHoloweb.Models.LawOrder;

namespace TheImperialHoloweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Bounty> LawBounties { get; set; }
    }
}
