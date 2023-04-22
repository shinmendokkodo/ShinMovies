using System.Collections.Generic;

namespace ShinMovies.Models.Entities;

public class Genre
{
    public int Id { get; set; }
    // [StringLength(maximumLength: 150)] --annotation
    // [Required] --annotation
    public string Name { get; set; }
    public HashSet<Movie> Movies { get; set; }
}
