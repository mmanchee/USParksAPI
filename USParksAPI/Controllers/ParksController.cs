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
    // GET api/parks/5
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }
    // PUT api/parks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }
    // DELETE api/parks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var rowToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(rowToDelete);
      _db.SaveChanges();
    }
    [HttpGet("Random")]
    public IEnumerable<Park> Random()
    {
      var count = _db.Parks.Count();
      Random ran = new Random();
      int skipTo = ran.Next(count);
      return _db.Parks.OrderBy(r => Guid.NewGuid()).Skip(skipTo).Take(1);
    }
  }
}