using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp
{
    public class ProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var client = _httpClientFactory.CreateClient("productapi");
            var result = await client.GetFromJsonAsync<Product[]>("/api/product");
            return result ?? Enumerable.Empty<Product>();
        }
    }
}
