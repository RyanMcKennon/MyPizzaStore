using PizzaStoreAPI.API.Models;
using PizzaStoreAPI.API.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.mappers
{
    public static class ToppingMapper
    {
        public static ToppingDTO ToppingDAO_ToppingDTO(ToppingDAO t)
        {
            var topping = new ToppingDTO();
            topping.ID = t.ID;
            topping.Name = t.Name;
            return topping;
        }

        public static ToppingDAO ToppingDTO_ToppingDAO(ToppingDTO t)
        {
            var topping = new ToppingDAO();
            topping.ID = t.ID;
            topping.Name = t.Name;
            return topping;
        }
    }
}