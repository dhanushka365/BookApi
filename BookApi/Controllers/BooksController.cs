using BookApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private Book[] _books = new Book[]
        {
            new Book { Id = 1, Author="pasindu" , Title =" BOOK-01" },
            new Book { Id = 2, Author="pasindu" , Title =" BOOK-02" },
            new Book { Id = 3, Author="pasindu" , Title =" BOOK-03" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
