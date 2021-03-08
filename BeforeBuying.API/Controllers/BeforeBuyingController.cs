using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeforeBuying.Business;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeforeBuying.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeforeBuyingController : ControllerBase
    {
        // GET: api/<BeforeBuyingController>
        [HttpGet]
        public IEnumerable<Model.ShopDataContract> Get()
        {
            Model.GetShopDBData dBRepository2 = new Model.GetShopDBData();
            //return dBRepository2.GetShopsAsync().Result;
            return dBRepository2.GetShops();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<BeforeBuyingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //DBRepository2 dBRepository2 = new DBRepository2();
            //return dBRepository2.GetShop().Result;
            return "value";
        }

        // POST api/<BeforeBuyingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BeforeBuyingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BeforeBuyingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
