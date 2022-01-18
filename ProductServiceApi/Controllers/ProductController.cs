using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {     
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Products.List;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id) => Products.List.FirstOrDefault(x => x.Id == id);

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            product.Id = Products.List.Max(x => x.Id) + 1;
            Products.List.Add(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            var p = Products.List.FirstOrDefault(x => x.Id == id);
            p = product;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Products.List = Products.List.Where(x => x.Id != id).ToList();
        }
    }

    public static class Products {
        private static List<Product> products = new()
        {
            new Product()
            {
                Name = "Phone",
                Price = 1200m,
                Id = 1
            },
            new Product()
            {
                Name = "Pc",
                Price = 5200m,
                Id = 2
            },
            new Product()
            {
                Name = "Tv",
                Price = 1900m,
                Id = 3
            },
        };
        public static List<Product> List { get => products; set => products = value; }
    }
}
