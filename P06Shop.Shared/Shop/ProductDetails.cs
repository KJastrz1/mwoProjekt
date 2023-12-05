using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Shop
{
    public class ProductDetails
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Manufactuer { get; set; }

        public DateTime ManufactureDate { get; set; }
    }
}
