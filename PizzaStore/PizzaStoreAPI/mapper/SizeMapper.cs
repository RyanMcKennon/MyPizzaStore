using PizzaStoreAPI.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class SizeMapper
    {
        public static Size SizeDAO_Size(SizeDAO dao)
        {
            var s = new Size();
            s.SizeID = dao.ID;
            s.Name = dao.Name;
            return s;
        }

        public static SizeDAO Size_SizeDAO(Size s)
        {
            var dao = new SizeDAO();
            dao.ID = s.SizeID;
            dao.Name = s.Name;
            return dao;
        }
    }
}