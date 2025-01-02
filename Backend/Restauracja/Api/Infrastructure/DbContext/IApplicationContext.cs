using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Api.Infrastructure.DbContext
{
    public interface IApplicationContext
    {
        DbSet<Dish> Dishes { get; set; }
        DbSet<Supply> Supplies { get; set; }
        DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}