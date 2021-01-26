using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server_Side_App.Models;

namespace Server_Side_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookContext _context;

        public BooksController(BookContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetBooks() // Beginn API-Endpoint => Alle Bücher holen
        {
            try
            {
                var mbooks = _context.Books.ToList();

                return Ok(mbooks);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Something went wrong: {ex.Message}");
            } // Endpoint fertig
        }
         
      

    }
}
