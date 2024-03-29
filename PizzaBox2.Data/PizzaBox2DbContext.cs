using Microsoft.EntityFrameworkCore;
using PizzaBox2.Domain.Models;
using System.Linq;

namespace PizzaBox2.Data
{

  public class PizzaBox2DbContext : DbContext
  {
    public DbSet<Preset> Presets {get; set;}
    public DbSet<PresetTopping> PresetToppings {get; set;}
    public DbSet<Size> Sizes {get; set;}
    public DbSet<Inventory> Inventories {get; set;}
    public DbSet<Transaction> Transactions {get; set;}
    public DbSet<Location> Locations {get; set;}
    public DbSet<User> Users {get; set;}
    public DbSet<Topping> Toppings {get; set;}
    public DbSet<Order> Orders {get; set;}
    public DbSet<Pizza> Pizzas {get; set;}
    public DbSet<Crust> Crusts {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;initial catalog=PizzaBox2Db;user id=sa;password=Password12345;");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.Id);
      
      builder.Entity<Size>().HasKey(s=> s.Id);

      builder.Entity<Inventory>().HasKey(i => i.Id);

      builder.Entity<Pizza>().HasKey(p => p.Id);

      builder.Entity<Order>().HasKey(o => o.Id);

      builder.Entity<Location>().HasKey(l => l.Id);

      builder.Entity<User>().HasKey(u => u.Id);

      builder.Entity<Topping>().HasKey(t => t.Id);

      builder.Entity<Transaction>().HasKey(t2 => t2.Id);

      builder.Entity<Preset>().HasKey(pre => pre.Id);

      builder.Entity<PresetTopping>().HasKey(ps => ps.Id);
      
    }
  }
}