using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeforeBuying.Business;
using BeforeBuying.Model;

namespace WebCoreApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // GET: api/BlogPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BeforeBuying.Model.Item>>> GetItem()
        {
            DBRepository2 dBRepository2 = new DBRepository2();
            return await dBRepository2.GetAllItemsAsync(1);

            //return await _context.BlogPosts.ToListAsync();
        }

        // GET: api/BlogPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            DBRepository2 dBRepository2 = new DBRepository2();
            Task<Item> item = dBRepository2.GetItemById(id);
            return await item;
        }

        // PUT: api/BlogPosts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemPost(int id, Item item)
        {
            DBRepository2 dBRepository2 = new DBRepository2();
            
            try
            {
                dBRepository2.InsertOrUpdateItem(item);
                await dBRepository2.SaveAsync();
            }
            catch (Exception ex)
            {
                throw ex;
                //if (!ItemPostExists(id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return NoContent();
        }

        // POST: api/BlogPosts
        [HttpPost]
        public async Task<ActionResult<Item>> PostBlogPost(Item item)
        {
            DBRepository2 dBRepository2 = new DBRepository2();
            dBRepository2.InsertOrUpdateItem(item);
            await dBRepository2.SaveAsync();

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        // DELETE: api/BlogPosts/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<BlogPost>> DeleteBlogPost(int id)
        //{
        //    var blogPost = await _context.BlogPosts.FindAsync(id);
        //    if (blogPost == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.BlogPosts.Remove(blogPost);
        //    await _context.SaveChangesAsync();

        //    return blogPost;
        //}

        //private bool ItemPostExists(int id)
        //{
        //    return _context.BlogPosts.Any(e => e.PostId == id);
        //}


    }
}
