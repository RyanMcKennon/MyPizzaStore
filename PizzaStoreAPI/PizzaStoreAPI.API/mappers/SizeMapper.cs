using PizzaStoreAPI.API.Models;
using PizzaStoreAPI.API.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.mappers
{
    public static class SizeMapper
    {
        public static SizeDTO SizeDAO_SizeDTO(SizesDAO s)
        {
            var e = new SizeDTO();
            e.ID = s.ID;
            e.Name = s.name;
            return e;
        }

        public static SizesDAO SizeDTO_SizeDAO(SizeDTO s)
        {
            var e = new SizesDAO();
            e.ID = s.ID;
            e.name = s.Name;
            return e;
        }
    }
}