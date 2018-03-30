using Microsoft.EntityFrameworkCore;
using SalesApp.API.Models;

namespace SalesApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }
}