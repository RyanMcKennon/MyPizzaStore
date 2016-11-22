using PizzaStore.DataAccess;
using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class SauceMapper
    {
        public static Sauce SauceDAO_Sauce(SauceDAO dao)
        {
            var s = new Sauce();
            s.SauceID = dao.ID;
            s.Name = dao.name;
            return s;
        }

        public static SauceDAO Sauce_SauceDAO(Sauce s)
        {
            var dao = new SauceDAO();
            dao.ID = s.SauceID;
            dao.name = s.Name;
            return dao;
        }
    }
}