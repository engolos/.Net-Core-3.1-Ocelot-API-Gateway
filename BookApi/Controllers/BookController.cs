using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        [Route("GetBooks")]
        public IActionResult GetBooks()
        {
            List<string> Books = new List<string>
            {
             "Book1","Book2","Book3"
            };
            return Ok(Books);
        }
    }
}
