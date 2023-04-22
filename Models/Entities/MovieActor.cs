namespace ShinMovies.Models.Entities;

public class MovieActor
{
    public int ActorId { get; set; }
    public int MovieId { get; set; }
    public string Character { get; set; }
    public int Order { get; set; }
    public Movie Movie { get; set; }
    public Actor Actor { get; set; }
}
