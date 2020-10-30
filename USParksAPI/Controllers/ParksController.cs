using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using USParksAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace USParksAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private USParksAPIContext _db;

    public ParksController(USParksAPIContext db)
    {
      _db = db;
    }

    // GET api/Parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string state, string city, string search) //Add Search
    {
      var query = _db.Parks.AsQueryable();
      if (search != null)
      {
        query = from park in query
                where EF.Functions.Like(park.Description, $"{search}")
                select park;
      }
      if (state != null)
      {
        query = from park in query
                where EF.Functions.Like(park.State, $"{state}")
                select park;
      }
      if (city != null)
      {
        query = from park in query
                where EF.Functions.Like(park.City, $"{city}")
                select park;
      }
      return query.ToList();
    }
    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
  }
}