using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PizzaAPI.client.Models;

namespace PizzaAPI.client.Controllers
{
    public class SauceController : ApiController
    {
        private service data = new service();
        // GET: api/Sauce
        public List<SauceDTO> Get()
        {
            return data.GetSauces();
        }

        // GET: api/Sauce/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sauce
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sauce/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sauce/5
        public void Delete(int id)
        {
        }
    }
}
