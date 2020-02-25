﻿using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : ApiController
    {

        private readonly RestaurantDbContext _context = new RestaurantDbContext();
        
        //post
        public async Task<IHttpActionResult> PostRestaurant(Restaurant restaurant)
        {
            if (ModelState.IsValid && restaurant != null)
            {
                _context.Restaurant.Add(restaurant);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        //Get all
        public async Task<IHttpActionResult> GetAll()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = await _context.Restaurant.ToListAsync<Restaurant>();
            return Ok(restaurants);
        }
        //Get by Id
        public async Task<IHttpActionResult> GetById(int id)
        {
            Restaurant target = await _context.Restaurant.FindAsync(id);
            

            if (target == null)
            {
                return NotFound();
            }
            return Ok(target);
        }
        //Put(Update)

        //Delete By Id

    }
}