using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LandsScraperApi.DataContext.Models;

public class Land
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? County { get; set; }
    public string? Origin { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int CreatedAtMonth { get; set; } = DateTime.UtcNow.Month;
    public int CreatedAtYear { get; set; } = DateTime.UtcNow.Year;
    public string? Status { get; set; }
    public float Price { get; set; } = 0.0f;
    public float PricePerAcre { get; set; } = 0.0f;
    public float Area { get; set; } = 0.0f;
    public float Acre { get; set; } = 0.0f;
    public int Bedrooms { get; set; } = 0;
    public int Bathrooms { get; set; } = 0;
    public bool Electricity { get; set; } = false;
    public bool Waterfront { get; set; } = false;
    public bool Mineral { get; set; } = false;
    public bool Well { get; set; } = false;
    public bool AgExempt { get; set; } = false;
    public string? Link { get; set; }
    public string? TimeOnWebsite { get; set; }
    public string? Address { get; set; }
}
