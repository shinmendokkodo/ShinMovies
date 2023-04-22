using System;
using System.Collections.Generic;

namespace ShinMovies.Models.Entities;

public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }
    // [Column(TypeName = "Date")] --annotation
    public DateTime? DateOfBirth { get; set; }
    public HashSet<MovieActor> MovieActors { get; set; }
}
