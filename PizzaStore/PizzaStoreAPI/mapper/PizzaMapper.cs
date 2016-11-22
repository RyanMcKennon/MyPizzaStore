using PizzaStore.DataAccess;
using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class PizzaMapper
    {
        public static Pizza PizzaDAO_Pizza(PizzaDAO s)
        {
            Pizza e = new Pizza();
            e.PizzaID = s.ID;
            e.CrustID = s.Crust.ID;
            e.SauceID = s.Sauce.ID;
            e.SizeID = s.Size.ID;
            return e;
        }

        public static List<Topping> PizzaDAO_Topping(PizzaDAO p)
        {
            List<Topping> t = new List<Topping>();
            foreach (var item in p.Toppings)
            {
                t.Add(ToppingMapper.ToppingDAO_Topping(item));
            }
            return t;
        }

        public static List<Cheese> PizzaDAO_Cheeses(PizzaDAO p)
        {
            List<Cheese> c = new List<Cheese>();
            foreach (var item in p.Cheeses)
            {
                c.Add(CheeseMapper.CheeseDAO_Cheese(item));
            }
            return c;
        }
    }
}