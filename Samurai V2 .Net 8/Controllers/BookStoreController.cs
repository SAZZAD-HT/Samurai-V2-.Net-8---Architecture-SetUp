using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Samurai_V2_.Net_8.DTOs;
using Samurai_V2_.Net_8.IRepository;

namespace Samurai_V2_.Net_8.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookStoreController : ControllerBase
    {
        private static IBookRepo _bookRepo;
        public BookStoreController(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

       
        [HttpPost(Name = "CreateNew")]
        public async Task<IActionResult> CreateNew(BookDto b)
        {
            var data = _bookRepo.CreateBook(b);
            return Ok(data);
        }
    }
}
