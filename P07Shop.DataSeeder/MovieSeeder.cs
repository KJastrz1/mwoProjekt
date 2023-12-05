using Bogus;
using P06Shop.Shared.MovieModel;

namespace P07Shop.DataSeeder
{
    public class MovieSeeder
    {
        public static List<Movie> GenerateMovieData()
        {
            int MovieId = 1;
            var MovieFaker = new Faker<Movie>("pl")
                .UseSeed(123456)
                .RuleFor(x => x.Title, x => x.Commerce.ProductName())              
                .RuleFor(x => x.Id, x => MovieId++)
                .RuleFor(x => x.Director, x => x.Name.FullName());

            return MovieFaker.Generate(50).ToList();

        }
    }
}