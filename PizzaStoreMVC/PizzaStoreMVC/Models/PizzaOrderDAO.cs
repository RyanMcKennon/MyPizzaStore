using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Models
{
    public class PizzaOrderDAO
    {
        public int ID { get; set; }
        public OrderDAO Order { get; set; }
        public CustomerDAO Customer { get; set; }
    }
}