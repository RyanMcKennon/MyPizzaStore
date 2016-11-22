using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public static class NameMapper
    {
        public static Name NameDAO_Name(NameDAO s)
        {
            var e = new Name();
            e.NameID = s.ID;
            e.FirstName = s.FirstName;
            e.LastName = s.LastName;
            return e;
        }

        public static NameDAO Name_NameDAO (Name s)
        {
            var e = new NameDAO();
            e.ID = s.NameID;
            e.FirstName = s.FirstName;
            e.LastName = s.LastName;
            return e;
        }
    }
}