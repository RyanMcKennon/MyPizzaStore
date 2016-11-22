﻿using PizzaAPI.client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.client.Controllers
{
    public class ToppingController : ApiController
    {
        private service data = new service();
        // GET: api/Topping
        public List<ToppingDTO> Get()
        {
            return data.GetToppings();
        }

        // GET: api/Topping/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Topping
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Topping/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Topping/5
        public void Delete(int id)
        {
        }
    }
}
