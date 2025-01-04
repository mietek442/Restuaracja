using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Api.Infrastructure.DbContext
{
    public interface IApplicationContext
    {
        DbSet<Dish> Dishes { get; set; }
        DbSet<Supply> Supplies { get; set; }
        DbSet<Order> Orders { get; set; }
        public DbSet<ResteurantUser> Users { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<RestaurantTable> Tables { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}