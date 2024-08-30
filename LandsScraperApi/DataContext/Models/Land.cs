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
    public int CreatedAtMonth { get; set; }
    public int CreatedAtYear { get; set; }
    public string? Status { get; set; }
    public float Price { get; set; }
    public float PricePerAcre { get; set; }
    public float Area { get; set; }
    public float Acre { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public bool Electricity { get; set; }
    public bool Waterfront { get; set; }
    public bool Mineral { get; set; }
    public bool Well { get; set; }
    public bool AgExempt { get; set; }
    public string? Link { get; set; }
}
