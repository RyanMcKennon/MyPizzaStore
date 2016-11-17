using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStore.Client.Models
{
    public class PizzaOrderDAO
    {
        [DataMember]
        public int PizzaOrderID { get; set; }
        [DataMember]
        public OrderDAO order { get; set; }
        [DataMember]
        public CustomerDAO customer { get; set; }
    }
}