using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Controllers
{
    public class PizzaOrderController : ApiController
    {
        private Service data = new Service();

        // GET: api/PizzaOrder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PizzaOrder/5
        public PizzaOrderDAO Get(int id)
        {
            return data.GetPizzaOrder(id);
        }

        // POST: api/PizzaOrder
        public void Post(PizzaOrderDAO pizzaorder)
        {
            data.InsertPizzaOrder(pizzaorder);
        }

        // PUT: api/PizzaOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PizzaOrder/5
        public void Delete(int id)
        {
        }
    }
}
