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
        public Sauce sauce { get; set; }
        [DataMember]
        public Crust crust { get; set; }
        [DataMember]
        public Size size { get; set; }
        [DataMember]
        public List<Topping> toppings { get; set; }
        [DataMember]
        public List<Cheese> cheeses { get; set; }
    }
}