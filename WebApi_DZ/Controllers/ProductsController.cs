using Microsoft.AspNetCore.Mvc;

namespace WebApi_DZ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly Products[] products = new[]
        {
            new Products(1, 2020, "MITSUBISHI", "Mitsubishi Heavy Industries", "Japan", 234589),
            new Products(2, 4620, "NISSAN", "Nissan Motor Co., Ltd", "Japan", 234899),
            new Products(3, 1020, "OPEL", "Opel Automobile GmbH", "Germany", 93489),
            new Products(4, 3050, "MCLAREN", "McLaren Automotive Limited", "British", 273489),
            new Products(5, 6020, "MASERATI", "Maserati S.p.A.", "Italy", 29489),
            new Products(6, 8020, "ROLLS-ROYCE", "Rolls-Royce Motor Cars Ltd", "British", 93487),
            new Products(7, 2090, "VOLKSWAGEN", "Volkswagen", "Germany", 993489)

        };
         public ProductsController(){}

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Products> Get()
        {
            return  products.ToArray();
        }

        [HttpGet("{id}")]
        public Products Get(int id)
        {
           return products.ToArray()[id];
        }



    }
}
