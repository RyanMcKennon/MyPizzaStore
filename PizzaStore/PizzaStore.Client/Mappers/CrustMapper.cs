using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public static class CrustMapper
    {
        public static CrustDAO Crust_CrustDAO (Crust c)
        {
            var dao = new CrustDAO();
            dao.ID = c.CrustID;
            dao.name = c.Name;
            return dao;
        }

        public static Crust CrustDAO_Crust(CrustDAO dao)
        {
            var c = new Crust();
            c.CrustID = dao.ID;
            c.Name = dao.name;
            return c;
        }
    }
}