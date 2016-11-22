using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.Models
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public List<PizzaDTO> pizzas { get; set; }
    }
}