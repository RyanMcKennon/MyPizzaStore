﻿using PizzaStoreAPI.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.API.Controllers
{
    public class SizeController : ApiController
    {
        private Service data = new Service();
        public List<SizeDTO> Get()
        {
            return data.GetSizes();
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