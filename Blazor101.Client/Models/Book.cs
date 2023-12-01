using System.ComponentModel.DataAnnotations;

namespace Blazor101.Client.Models;

public class Book
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public required string Name { get; set; }
    
    [Required]
    [StringLength(30)]
    public required string Genre { get; set; }
    
    [Required]
    [Range(1, 70000)]
    public decimal Price { get; set; }
    
    [Required]
    public DateTime ReleaseDate { get; set; }
}
