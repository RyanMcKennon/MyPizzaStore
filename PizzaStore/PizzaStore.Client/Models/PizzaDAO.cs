using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStore.Client.Models
{
    public class PizzaDAO
    {
        [DataMember]
        public int PizzaID { get; set; }
        [DataMember]
        public SauceDAO sauce { get; set; }
        [DataMember]
        public CrustDAO crust { get; set; }
        [DataMember]
        public SizesDAO size { get; set; }
        [DataMember]
        public List<ToppingDAO> toppings { get; set; }
        [DataMember]
        public List<CheeseDAO> cheeses { get; set; }
    }
}