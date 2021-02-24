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
    public class CustomerController : ApiController
    {
        // Challenge: Get C & R working, i.e.

        // Post a Customer

        // Get all Customers

        // Test them in Postman

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllCustomers()
        {
            List<Customer> customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCustomerById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == default)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCustomerByName(string firstName, string lastName)
        {
            List<Customer> customers;
            if (firstName == default)
            {
                customers = await _context.Customers
                .Where(c => c.LastName.ToLower() == lastName.ToLower())
                .ToListAsync();
            } else if (lastName == default)
            {
                customers = await _context.Customers
                .Where(c => c.FirstName.ToLower() == firstName.ToLower())
                .ToListAsync();
            } else
            {
                customers = await _context.Customers
                .Where(c => c.LastName.ToLower() == lastName.ToLower()
                    && c.FirstName.ToLower() == firstName.ToLower())
                .ToListAsync();
            }

            return Ok(customers);
        }
    }
}
