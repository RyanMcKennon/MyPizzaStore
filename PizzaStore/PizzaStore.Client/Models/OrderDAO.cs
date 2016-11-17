using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStore.Client.Models
{
    public class OrderDAO
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public List<PizzaDAO> pizzas {get;set;} 
    }
}