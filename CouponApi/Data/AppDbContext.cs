using CouponApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CouponApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Coupon> Coupons { get; set; }  
    }
}
