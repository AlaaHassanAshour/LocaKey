using LocaKey.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocaKey.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<CartBasket> CartBaskets { get; set; }
        public DbSet<CartCookies> CartCookies { get; set; }
        public DbSet<Category> Categorys{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVisitsReport> ProductVisitsReports { get; set; }
        public DbSet<productReport> productReport { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<language> language { get; set; }
        public DbSet<privacyPolicy> privacyPolicy { get; set; }
        public DbSet<ReplacementRecoveryPolicy> ReplacementRecoveryPolicy { get; set; }
        public DbSet<SalesReport> SalesReport { get; set; }
        public DbSet<SiteVisitsReport> SiteVisitsReport { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}