using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Controllers
{
    public class CrustController : ApiController
    {
        private Service data = new Service();
        // GET: api/Topping
        public List<CrustDAO> Get()
        {
            return data.getCrusts();
        }

        // GET: api/Crust/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Crust
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Crust/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Crust/5
        public void Delete(int id)
        {
        }
    }
}
