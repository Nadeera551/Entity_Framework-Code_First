using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            //CRUD
            using(var _context = new BookStoresDBContext())
            {
                // Publisher publisher = new Publisher();
                // publisher.PublisherName = "Harry Potter";

                // _context.Publishers.Add(publisher);

                // _context.SaveChanges();
                Publisher publisher = _context.Publishers.FirstOrDefault();
                // publisher.PublisherName = "Harry Potter1";

                _context.Publishers.Remove(publisher);

                _context.SaveChanges();

                return _context.Publishers.ToList();

            }
            
        }
    }
}
