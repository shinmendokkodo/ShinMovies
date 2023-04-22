using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreMovies.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShinMovies.Extensions;
using ShinMovies.Models.DTOs;
using ShinMovies.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShinMovies.Controllers;

[Route("api/actors")]
[ApiController]
public class ActorsController : ControllerBase
{
    private readonly ApplicationContext context;
    private readonly IMapper mapper;

    public ActorsController(ApplicationContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> Get(int page = 1, int pageSize = 2)
    {
        var actors = await context.Actors.AsNoTracking()
            .OrderBy(a => a.Name)
            .ProjectTo<ActorDTO>(mapper.ConfigurationProvider)
            .Paginate(page, pageSize)
            .ToListAsync();

        return Ok(actors);
    }

    [HttpGet("ids")]
    public async Task<ActionResult<IEnumerable<int>>> GetIds()
    {
        var actorIds = await context.Actors.Select(a => a.Id).ToListAsync();
        return Ok(actorIds);
    }
}
