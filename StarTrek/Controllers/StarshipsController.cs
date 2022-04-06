using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarTrek.Models;

namespace StarTrek.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StarshipsController : ControllerBase
  {
    private readonly StarTrekContext _db;

    public StarshipsController(StarTrekContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Starship>>> Get(string shipModel, string shipClass, string name, string captain, string launch)
    {
      var query = _db.Starships.AsQueryable();

      if (shipModel != null)
      {
        query = query.Where(entry => entry.ShipModel == shipModel);
      }
      if (shipClass != null)
      {
        query = query.Where(entry => entry.ShipClass == shipClass);
      }
      if (captain != null)
      {
        query = query.Where(entry => entry.Captain == captain);
      }
      if (launch != null)
      {
        query = query.Where(entry => entry.Launch == launch);
      }
      return await query.ToListAsync();
    }
      

    private bool StarshipExists(int id)
    {
      return _db.Starships.Any(e => e.StarshipId == id);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Starship>> GetStarship(int id)
    {
      var starship = await _db.Starships.FindAsync(id);
      if ( starship == null )
      {
        return NotFound();
      }
      return starship;
    }
  }
}