using LandsScraperApi.DataContext.Models;
using Microsoft.EntityFrameworkCore;

namespace LandsScraperApi.DataContext;

public class LandDbContext(DbContextOptions<LandDbContext> options) : DbContext(options ?? throw new ArgumentNullException(nameof(options)))
{
    public DbSet<Land> Lands { get; set; }
}
