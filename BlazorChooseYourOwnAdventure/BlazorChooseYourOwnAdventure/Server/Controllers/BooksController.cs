using BlazorChooseYourOwnAdventure.Shared;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorChooseYourOwnAdventure.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/Books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < 10; i++)
            {
                int b = i + 100;
                Book book = new Book
                {
                    _bookid = i,
                    _booktitle = $"Book {i}",
                    _bookcategory = $"Level {i}",
                    _bookdescription = $"Book {i} of series",
                    _bookauthor = $"{i} Author",
                };
                for (int x = 0; x < b; x++)
                {
                    book._bookpages?.Add(x);
                }
                books.Add(book);
            }
            return books.ToArray();
        }

        // GET api/Books/5
        [HttpGet("{id}")]
        public Book? Get(int id)
        {
            return null;
        }

        // POST api/Books
        [HttpPost]
        public void Post([FromBody] Book value)
        {
        }

        // PUT api/Books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
        }

        [HttpPatch("id")]
        public void Patch(int id, [FromBody] Book value)
        {

        }

        // DELETE api/Books/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
