using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        [Route("GetAuthors")]
        public IActionResult GetAuthors()
        {
            List<string> Books = new List<string>
            {
             "Author1","Author1","Author1"
            };
            return Ok(Books);
        }
    }
}
