using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Controllers
{
    public class CustomerController : ApiController
    {
        Service data = new Service();
        // GET: api/Customer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        public List<PizzaOrderDAO> Get(int id)
        {
            return data.CustomerOrderHistory(id);
        }

        // POST: api/Customer
        public void Post(CustomerDAO customer)
        {
            data.InsertCustomer(customer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
