using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public static class ToppingMapper
    {
        public static ToppingDAO Topping_ToppingDAO (Topping t)
        {
            ToppingDAO topping = new ToppingDAO();
            topping.ID = t.ToppingID;
            topping.Name = t.Name;
            return topping;
        }

        public static Topping ToppingDAO_Topping(ToppingDAO t)
        {
            Topping topping = new Topping();
            topping.ToppingID = t.ID;
            topping.Name = t.Name;
            return topping;
        }
    }
}