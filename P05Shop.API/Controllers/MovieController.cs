using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using P06Shop.Shared;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieModel;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieService _MovieService;
        private readonly ILogger<MovieController> _logger;
        public MovieController(IMovieService MovieService, ILogger<MovieController> logger)
        {
            _MovieService = MovieService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Movie>>>> GetMovies()
        {
            _logger.Log(LogLevel.Critical, "Invoked GetMovies Method in controller");

            var result = await _MovieService.GetMoviesAsync();

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(501, $" {result.Message}");
        }

        [HttpGet("search/{text}/{page}/{pageSize}")]
        [HttpGet("search/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceResponse<PaginatedResult<Movie>>>> SearchMovies(string? text=null, int page=1, int pageSize=10)
        {         

            var result = await _MovieService.SearchMoviesAsync(text,page,pageSize);
        
            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }


        // http:localhost/api/Movie/4 dla api REST
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Movie>>> GetMovie(int id)
        {
          
            var result = await _MovieService.GetMovieByIdAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }


        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Movie>>> UpdateMovie([FromBody] Movie Movie)
        {
            
            var result = await _MovieService.UpdateMovieAsync(Movie);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Movie>>> CreateMovie([FromBody] Movie Movie)
        {
            var result = await _MovieService.CreateMovieAsync(Movie);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        // http:localhost/api/Movie/delete?id=4
        // http:localhost/api/Movie/4 dla api REST
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteMovie([FromRoute] int id)
        {
            var result = await _MovieService.DeleteMovieAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }



    }
}
