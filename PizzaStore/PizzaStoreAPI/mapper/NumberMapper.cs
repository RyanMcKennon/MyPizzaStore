using PizzaStoreAPI.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class NumberMapper
    {
        public static PhoneNumber NumberDAO_Number(NumberDAO s)
        {
            var e = new PhoneNumber();
            e.PhoneNumberID = s.ID;
            e.PhoneNumber1 = s.Number;
            return e;
        }

        public static NumberDAO Number_NumberDAO(PhoneNumber s)
        {
            var e = new NumberDAO();
            e.ID = s.PhoneNumberID;
            e.Number = s.PhoneNumber1;
            return e;
        }
    }
}