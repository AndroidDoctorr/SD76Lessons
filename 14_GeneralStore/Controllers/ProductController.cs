using _14_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _14_GeneralStore.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProductByUpc(string upc)
        {
            Product product = await _context.Products
                .FirstOrDefaultAsync(p => p.UPC.ToLower() == upc.ToLower());

            return Ok(product);
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] ProductUpdate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            var product = await _context.Products.FindAsync(id);

            if (product == default)
            {
                return NotFound(); // 404
            }

            if (!string.IsNullOrEmpty(model.ProductName))
            {
                product.ProductName = model.ProductName;
            }
            if (!string.IsNullOrEmpty(model.UPC))
            {
                product.UPC = model.UPC;
            }
            if (model.Price > 0)
            {
                product.Price = model.Price;
            }

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500
        }

        [HttpPut]
        [ActionName("Restock")]
        public async Task<IHttpActionResult> RestockProduct([FromUri] int id, [FromUri] int amt)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == default)
            {
                return NotFound(); // 404
            }

            if (amt < 1)
            {
                return BadRequest("Amount must be at least 1");
            }

            product.Quantity += amt;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok($"{amt} {product.ProductName} added.");
            }

            return InternalServerError();
        }
    }
}
