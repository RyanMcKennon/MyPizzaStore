using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Controllers
{
    public class CheeseController : ApiController
    {
        private Service data = new Service();
        // GET: api/Topping
        public List<CheeseDAO> Get()
        {
            return data.getCheeses();
        }

        // GET: api/Cheese/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cheese
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cheese/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cheese/5
        public void Delete(int id)
        {
        }
    }
}
