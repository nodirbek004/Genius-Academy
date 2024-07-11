using Academy.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Academy.Api.Data;
public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}
