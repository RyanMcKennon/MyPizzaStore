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
        public Name name { get; set; }
        [DataMember]
        public Email email { get; set; }
        [DataMember]
        public CustomerAddress address { get; set; }
        [DataMember]
        public PhoneNumber number { get; set; }
    }
}