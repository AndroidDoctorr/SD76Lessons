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
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> PurchaseProduct(Transaction transaction)
        {
            // transaction.DateOfTransaction = DateTime.Now;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Transactions.Add(transaction);

            var product = await _context.Products.FindAsync(transaction.ProductId);

            if (product.Quantity < transaction.Quantity)
            {
                return BadRequest("Sorry, we don't have that many in stock :(");
            }
            product.Quantity -= transaction.Quantity;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllTransactions()
        {
            var transactions = await _context.Transactions.ToListAsync();
            return Ok(transactions);
        }
    }
}
