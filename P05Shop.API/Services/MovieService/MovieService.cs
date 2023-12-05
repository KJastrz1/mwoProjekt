using Microsoft.EntityFrameworkCore;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.MovieModel;
using P06Shop.Shared.Services.MovieService;

using P07Shop.DataSeeder;

namespace P05Shop.API.Services.MovieService
{
    public class MovieService : IMovieService
    {
        private readonly DataContext _dataContext;
        public MovieService(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<ServiceResponse<Movie>> CreateMovieAsync(Movie Movie)
        {
            try
            {
                _dataContext.Movies.Add(Movie);
                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<Movie>() { Data = Movie, Success = true };
            }
            catch (Exception)
            {
                return new ServiceResponse<Movie>()
                {
                    Data = null,
                    Success = false,
                    Message = "Cannot create Movie"
                };
            }
          
        }

        public async Task<ServiceResponse<bool>> DeleteMovieAsync(int id)
        {
            // sposób 1 (najpierw znajdujemy potem go usuwamy): 
            //var MovieToDelete = _dataContext.Movies.FirstOrDefault(x => x.Id == id);
            //_dataContext.Movies.Remove(MovieToDelete);  

            // sposób 2: (uzywamy attach : tylko jedno zapytanie do bazy)
            var Movie = new Movie() { Id = id };
            _dataContext.Movies.Attach(Movie);
            _dataContext.Movies.Remove(Movie);
            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<bool>() {  Data = true, Success = true };
        }

        public async Task<ServiceResponse<Movie>> GetMovieByIdAsync(int id)
        {
            try
            {
                var Movie = await _dataContext.Movies.FindAsync(id);
                var response = new ServiceResponse<Movie>()
                {
                    Data = Movie,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<Movie>()
                {
                    Data = null,
                    Message = "Problem with database",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            var Movies = await _dataContext.Movies.ToListAsync();

            try
            {
                var response = new ServiceResponse<List<Movie>>()
                {
                    Data = Movies,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new  ServiceResponse<List<Movie>>()
                {
                    Data = null,
                    Message = "Problem with database",
                    Success = false
                };
            }
           
        }

 public async Task<ServiceResponse<PaginatedResult<Movie>>> SearchMoviesAsync(string text, int page, int pageSize)
{
    try
    {
        IQueryable<Movie> query = _dataContext.Movies;

        if (!string.IsNullOrEmpty(text))
            query = query.Where(x => x.Title.Contains(text) || x.Director.Contains(text));

        var totalRecords = await query.CountAsync();

        var movies = await query
            .Skip(pageSize * (page - 1))
            .Take(pageSize)
            .ToListAsync();

        var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

        var response = new ServiceResponse<PaginatedResult<Movie>>()
        {
            Data = new PaginatedResult<Movie>
            {
                Data = movies,
                TotalRecords = totalRecords,
                PageSize = pageSize,
                CurrentPage = page
            },
            Message = "Ok",
            Success = true
        };

        return response;
    }
    catch (Exception)
    {
        return new ServiceResponse<PaginatedResult<Movie>>()
        {
            Data = null,
            Message = "Problem with the database",
            Success = false
        };
    }
}


        public async Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie Movie)
        {
            try
            {
                var MovieToEdit = new Movie() { Id = Movie.Id };
                _dataContext.Movies.Attach(MovieToEdit);

                MovieToEdit.Title = Movie.Title;
                MovieToEdit.Director = Movie.Director;
      

                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<Movie> { Data = MovieToEdit, Success = true };
            }
            catch (Exception)
            {
                return new ServiceResponse<Movie>
                {
                    Data = null,
                    Success = false,
                    Message = "An error occured while updating Movie"
                };
            }
            

            
        }
    }
}
