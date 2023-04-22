using EFCoreMovies.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShinMovies.Extensions;
using ShinMovies.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMovies.Controllers;

[Route("api/genres")]
[ApiController]
public class GenresController : ControllerBase
{
    private readonly ApplicationContext context;

    public GenresController(ApplicationContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Genre>>> Get(int page = 1, int pageSize = 2)
    {
        var genres = await context.Genres.AsNoTracking()
            .OrderBy(g => g.Name)
            .Paginate(page, pageSize)
            .ToListAsync();
        
        return Ok(genres);
    }

    [HttpGet("first/{input}")]
    public async Task<ActionResult<Genre>> GetFirst(string input)
    {
        var genre = await context.Genres.FirstOrDefaultAsync(g => g.Name.Contains(input));

        if (genre is null)
        {
            return NotFound();
        }

        return Ok(genre);
    }

    [HttpGet("filter")]
    public async Task<ActionResult<IEnumerable<Genre>>> Filter(string name)
    {
        var genres = await context.Genres.Where(g => g.Name.Contains(name)).ToListAsync();
        return Ok(genres);
    }
}
