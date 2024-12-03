using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Superhero.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperheroController : ControllerBase
    {
        private static List<SuperheroItem> Superheroes = new List<SuperheroItem> {
            new SuperheroItem { Id= 1, Name = "Superman"  },
            new SuperheroItem { Id= 2, Name = "Batman"    },
            new SuperheroItem { Id= 3, Name = "Spiderman" }
        };

        [HttpGet]
        public ActionResult<List<SuperheroItem>> Get()
        {
            return Ok(Superheroes);
        }
    }
}