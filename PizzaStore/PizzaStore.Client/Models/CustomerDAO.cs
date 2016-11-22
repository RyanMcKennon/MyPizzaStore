using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStore.Client.Models
{
    public class CustomerDAO
    {
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public NameDAO name { get; set; }
        [DataMember]
        public EmailDAO email { get; set; }
        [DataMember]
        public AddressDAO address { get; set; }
        [DataMember]
        public NumberDAO number { get; set; }
    }
}