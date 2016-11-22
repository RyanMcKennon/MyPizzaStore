
using PizzaStore.DataAccess;
using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class AddressMapper
    {
        public static CustomerAddress AddressDAO_Address (AddressDAO s)
        {
            var e = new CustomerAddress();
            e.AddressID = s.ID;
            e.CustomerAddress1 = s.Address;
            return e;
        }

        public static AddressDAO Address_AddressDAO (CustomerAddress s)
        {
            var e = new AddressDAO();
            e.ID = s.AddressID;
            e.Address = s.CustomerAddress1;
            return e;
        }
    }
}