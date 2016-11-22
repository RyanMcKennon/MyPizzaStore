using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.Models
{
    public class CustomerDTO
    {
        public int ID { get; set; }
        public NameDTO Name { get; set; }
        public NumberDTO Number { get; set; }
        public EmailDTO Email { get; set; }
        public AddressDTO Address { get; set; }
    }
}