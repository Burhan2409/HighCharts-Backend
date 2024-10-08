using Microsoft.AspNetCore.Mvc;
using MoviesAPIChart.Model;

namespace MoviesAPIChart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieDataController : Controller
    {
        private readonly InboxContext dbcontext;

        public MovieDataController(InboxContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpGet]

        public IActionResult GetMovie()
        {
            var list = dbcontext.Movies.ToList();
            return Ok(list);
        }
    }
}
