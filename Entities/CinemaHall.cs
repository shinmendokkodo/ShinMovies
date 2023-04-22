using System.Collections.Generic;

namespace EFCoreMovies.Entities;

public class CinemaHall
{
    public int Id { get; set; }
    // [Precision(precision:9, scale:2)] --annotation
    public decimal Cost { get; set; }
    public int CinemaId{ get; set; }
    public Cinema Cinema { get; set; }
    public CinemaHallType CinemaHallType { get; set; }
    public HashSet<Movie> Movies { get; set; }
}
