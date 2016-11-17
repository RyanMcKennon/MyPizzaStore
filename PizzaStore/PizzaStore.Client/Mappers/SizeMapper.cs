using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public static class SizeMapper
    {
        public static Size SizeDAO_Size(SizesDAO dao)
        {
            var s = new Size();
            s.SizeID = dao.ID;
            s.Name = dao.name;
            return s;
        }

        public static SizesDAO Size_SizeDAO(Size s)
        {
            var dao = new SizesDAO();
            dao.ID = s.SizeID;
            dao.name = s.Name;
            return dao;
        }
    }
}