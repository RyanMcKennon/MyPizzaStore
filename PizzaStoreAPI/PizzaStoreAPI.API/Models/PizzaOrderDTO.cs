using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.Models
{
    public class PizzaOrderDTO
    {
        public int ID { get; set; }
        public OrderDTO order { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}