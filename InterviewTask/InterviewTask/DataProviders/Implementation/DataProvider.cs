using System.Text.Json;
using InterviewTask.DataProviders.Contract;
using InterviewTask.DataProviders.Models;

namespace InterviewTask.DataProviders.Implementation
{
    public class DataProvider : IDataProvider
    {
        public async Task<List<ProductResponse>> GetProductsAsync()
        {
            var result = new List<ProductResponse>();
            
            result.AddRange(await GetTheTourGuyProductsAsync());
            result.AddRange(await GetTheBigGuyProductsAsync());
            result.AddRange(await GetSomeOtherGuyProductsAsync());

            return result;
        }

        private async Task<List<ProductResponse>> GetSomeOtherGuyProductsAsync()
        {
            using FileStream stream = File.OpenRead("SomeOtherGuyData.json");
            var products = await JsonSerializer.DeserializeAsync<SomeOtherGuyModel>(stream);
            
            return products.Products.Select(item => new ProductResponse
            {
                ProductName = item.Name,
                Description = item.ProductDescription,
                Price = item.Price,
                SupplierName = "Some Other Guy",
                Destination = "Thailand",
                Capacity = item.Capacity,
            }).ToList();

        }

        private async Task<List<ProductResponse>> GetTheBigGuyProductsAsync()
        {
            using FileStream stream = File.OpenRead("TheBigGuy.json");
            var products = await JsonSerializer.DeserializeAsync<TheBigGuyModel>(stream);

            return products.ProductData.Select(item => new ProductResponse
            {
                ProductName = item.ProductDetailData.Name,
                Description = item.ProductDetailData.ProductDescription,
                Price = item.Price.Amount,
                SupplierName = "The Big Guy",
                Destination = "Iceland",
                Capacity = item.ProductDetailData.Capacity
            }).ToList();
        }

        private async Task<List<ProductResponse>> GetTheTourGuyProductsAsync()
        {
            using FileStream stream = File.OpenRead("TheTourGuyData.json");
            var products = await JsonSerializer.DeserializeAsync<TheTourGuyModel>(stream);

            return products.Data.Select(item => new ProductResponse
            {
                ProductName = item.Title,
                Description = item.Description,
                Price = item.RegularPrice,
                Capacity = item.MaximumGuests,
                SupplierName = "The Tour Guy",
                Destination = "Mexico"
            }).ToList();
        }
    }
}
