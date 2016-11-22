using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Models
{
    public class CustomerDAO
    {
        public int ID { get; set; }
        public NameDAO Name { get; set; }
        public EmailDAO Email { get; set; }
        public NumberDAO Number { get; set; }
        public AddressDAO Address { get; set; }
    }
}