using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Backend.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetPosts()
        {

            return Ok(null);
        }
    }
}
