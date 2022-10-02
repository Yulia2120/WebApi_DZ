namespace WebApi_DZ
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOfManufacture { get; set; }
        public decimal Price { get; set; }

      

      
        public Product(int id, int productId, string title, string manufactures, string countryOfManufacture, decimal price)
        {
            Id = id;
            ProductId = productId;
            Title = title;
            Manufacturer = manufactures;
            CountryOfManufacture = countryOfManufacture;
            Price = price;
           
        }

    
    }
}
