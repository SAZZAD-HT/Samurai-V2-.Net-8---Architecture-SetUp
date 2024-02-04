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
        
        private readonly ILogger<BookStoreController> _logger;

        public BookStoreController(ILogger<BookStoreController> logger, IBookRepo bookRepo)
        {
            _logger = logger;
            _bookRepo = bookRepo;
        }

        [HttpPost(Name = "CreateNew")]
        public async Task<IActionResult> CreateNew(BookDto b)
        {
            var data =await  _bookRepo.CreateBook(b);
            return Ok(data);
        }
    }
}
