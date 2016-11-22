using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Controllers
{
    public class SizeController : ApiController
    {
        private Service data = new Service();
        // GET: api/Topping
        public List<SizeDAO> Get()
        {
            return data.getSizes();
        }

        // GET: api/Size/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Size
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Size/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Size/5
        public void Delete(int id)
        {
        }
    }
}
