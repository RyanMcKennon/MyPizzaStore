﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreAPI.Models
{
    public class NumberDAO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Number { get; set; }
    }
}