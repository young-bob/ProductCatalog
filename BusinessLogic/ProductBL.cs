using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.BusinessLogic
{
    public class ProductBL
    {
        private AppDbContext _dbContext;

        public ProductBL()
        {
            _dbContext = new AppDbContext();

            initTestData();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product? GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        private void initTestData()
        {
            if (_dbContext.Products.Count() == 0)
            {
                var products = new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        ProductName = "iPhone 17 Pro",
                        ProductPrice = 999.99m,
                        ImageUrl = "https://store.storeimages.cdn-apple.com/1/as-images.apple.com/is/iphone-card-40-17pro-202509?wid=680&hei=528&fmt=p-jpg&qlt=95",
                        Description = "The first iPhone to feature an aerospace-grade titanium design."
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "AirPods Pro (2nd Gen)",
                        ProductPrice = 249.00m,
                        ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/MTJV3?wid=1144&hei=1144&fmt=jpeg&qlt=90",
                        Description = "Rich audio. Magical active noise cancellation."
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "iPad Air",
                        ProductPrice = 599.00m,
                        ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/ipad-air-storage-select-202207-blue?wid=2560&hei=1440&fmt=p-jpg&qlt=95",
                        Description = "Light. Bright. Full of might."
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "MacBook Air 15-inch",
                        ProductPrice = 1299.00m,
                        ImageUrl = "https://store.storeimages.cdn-apple.com/1/as-images.apple.com/is/mac-card-40-macbook-air-202503?wid=680&hei=528&fmt=p-jpg&qlt=95",
                        Description = "Impressively big. Impossibly thin."
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Apple Watch Series 9",
                        ProductPrice = 399.00m,
                        ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/watch-card-40-s9-202309?wid=1200&hei=1500&fmt=p-jpg&qlt=95",
                        Description = "Smarter. Brighter. Mightier."
                    }
                };

                _dbContext.Products.AddRange(products);
                _dbContext.SaveChanges();

            }
        }
    }
}
