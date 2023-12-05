using Bogus;
using P06Shop.Shared.Shop;

namespace P07Shop.DataSeeder
{
    public class ProductSeeder
    {
        public static List<Product> GenerateProductData()
        {
            int productId = 1;
            var productFaker = new Faker<Product>("pl")
                .UseSeed(123456)
                .RuleFor(x => x.Title, x => x.Commerce.ProductName())
                .RuleFor(x => x.Description, x => x.Commerce.ProductDescription())
                .RuleFor(x => x.Id, x => productId++)
                .RuleFor(x => x.Barcode, x => x.Commerce.Ean13().Substring(12))
                .RuleFor(x => x.Price, x => x.Random.Double(1, 1000))
                .RuleFor(x => x.ReleaseDate, x => x.Date.Past());

            return productFaker.Generate(50).ToList();

        }
    }
}