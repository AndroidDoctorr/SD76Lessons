using _13_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _13_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> PostRating(Rating model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Ratings.Add(model);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500
        }


        [HttpGet]
        public async Task<IHttpActionResult> GetAllRatings()
        {
            List<Rating> ratings = await _context.Ratings.ToListAsync();
            return Ok(ratings);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllRatingsForRestaurant(int id)
        {
            List<Rating> ratings = await _context.Ratings
                // LINQ
                .Where(r => r.RestaurantId == id)
                .ToListAsync();
            return Ok(ratings);
        }
    }
}
