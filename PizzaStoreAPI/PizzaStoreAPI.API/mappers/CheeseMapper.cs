using PizzaStoreAPI.API.Models;
using PizzaStoreAPI.API.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.mappers
{
    public static class CheeseMapper
    {
        public static CheeseDTO CheeseDAO_CheeseDTO(CheeseDAO s)
        {
            var e = new CheeseDTO();
            e.ID = s.ID;
            e.Name = s.name;
            return e;
        }

        public static CheeseDAO CheeseDTO_CheeseDAO(CheeseDTO s)
        {
            var e = new CheeseDAO();
            e.ID = s.ID;
            e.name = s.Name;
            return e;
        }
    }
}