using PizzaStoreAPI.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class CrustMapper
    {
        public static CrustDAO Crust_CrustDAO (Crust c)
        {
            var dao = new CrustDAO();
            dao.ID = c.CrustID;
            dao.Name = c.Name;
            return dao;
        }

        public static Crust CrustDAO_Crust(CrustDAO dao)
        {
            var c = new Crust();
            c.CrustID = dao.ID;
            c.Name = dao.Name;
            return c;
        }
    }
}