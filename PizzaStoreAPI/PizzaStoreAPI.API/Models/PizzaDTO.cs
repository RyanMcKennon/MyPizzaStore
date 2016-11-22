using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.Models
{
    public class PizzaDTO
    {
        public int ID { get; set; }
        public List<ToppingDTO> toppings { get; set; }
        public List<CheeseDTO> cheeses { get; set; }
        public CrustDTO crust { get; set; }
        public SauceDTO sauce {get;set;}
        public SizeDTO size { get; set; }
    }
}