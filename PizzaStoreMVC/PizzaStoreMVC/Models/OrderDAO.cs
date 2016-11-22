using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Models
{
    public class OrderDAO
    {
        public int ID { get; set; }
        public List<PizzaDAO> Pizzas { get; set; }
    }
}