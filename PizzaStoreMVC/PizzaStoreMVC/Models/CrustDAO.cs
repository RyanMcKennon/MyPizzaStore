using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Models
{
    public class CrustDAO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool picked { get; set; }
    }
}