using Microsoft.AspNetCore.Mvc;

namespace WebApi_DZ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly Product[] product = new[]
        {
            new Product(1, 2020, "MITSUBISHI", "Mitsubishi Heavy Industries", "Japan", 234589),
            new Product(2, 4620, "NISSAN", "Nissan Motor Co., Ltd", "Japan", 234899),
            new Product(3, 1020, "OPEL", "Opel Automobile GmbH", "Germany", 93489),
            new Product(4, 3050, "MCLAREN", "McLaren Automotive Limited", "British", 273489),
            new Product(5, 6020, "MASERATI", "Maserati S.p.A.", "Italy", 29489),
            new Product(6, 8020, "ROLLS-ROYCE", "Rolls-Royce Motor Cars Ltd", "British", 93487),
            new Product(7, 2090, "VOLKSWAGEN", "Volkswagen", "Germany", 993489)

        };
         public ProductController(){}

        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Product> Get()
        {
            return  product.ToArray();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
           return product.ToArray()[id];
        }



    }
}
