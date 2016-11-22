using PizzaStoreAPI.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class EmailMapper
    {
        public static Email EmailDAO_Email(EmailDAO s)
        {
            var e = new Email();
            e.EmailID = s.ID;
            e.Email1 = s.Email;
            return e;
        }

        public static EmailDAO Email_EmailDAO(Email s)
        {
            var e = new EmailDAO();
            e.ID = s.EmailID;
            e.Email = s.Email1;
            return e;
        }
    }
}