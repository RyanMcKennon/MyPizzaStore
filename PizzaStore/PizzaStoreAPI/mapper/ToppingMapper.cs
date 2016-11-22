using PizzaStore.DataAccess;
using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class ToppingMapper
    {
        public static ToppingDAO Topping_ToppingDAO(Topping t)
        {
            var topping = new ToppingDAO();
            topping.ID = t.ToppingID;
            topping.Name = t.Name;
            return topping;
        }

        public static Topping ToppingDAO_Topping(ToppingDAO t)
        {
            var topping = new Topping();
            topping.ToppingID = t.ID;
            topping.Name = t.Name;
            return topping;
        }
    }
}