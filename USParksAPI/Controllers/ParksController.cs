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
    public ActionResult<IEnumerable<Park>> Get() //Add Search
    {
      return _db.Parks.ToList();
    }