using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.Models
{
    public class PizzaDAO
    {
        public int ID { get; set; }
        public CrustDAO Crust { get; set; }
        public SizeDAO Size { get; set; }
        public SauceDAO Sauce { get; set; }
        public List<ToppingDAO> Toppings { get; set; }
        public List<CheeseDAO> Cheeses { get; set; }
    }
}