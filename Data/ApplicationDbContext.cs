using FirstTest.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstTest.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees => Set<Employee>();
}
