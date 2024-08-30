using LandsScraperApi.DataContext;
using LandsScraperApi.DataContext.Models;
using Microsoft.AspNetCore.Mvc;

namespace LandsScraperApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LandController(LandDbContext dbContext) : ControllerBase
{
    private readonly LandDbContext _landDbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    [HttpPost]
    [Route("SaveLands")]
    public async Task<IActionResult> SaveLands([FromBody] List<Land> Lands)
    {
        await _landDbContext.AddRangeAsync(Lands);
        await _landDbContext.SaveChangesAsync();
        return Ok();
    }
}
