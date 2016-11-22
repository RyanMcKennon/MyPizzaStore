using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStore.Client.Models
{
    public class EmailDAO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Email { get; set; }

    }
}