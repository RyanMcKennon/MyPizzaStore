using PizzaStore.Client.Mappers;
using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public class PizzaMapper
    {
        public static Pizza PizzaDAO_Pizza(PizzaDAO p)
        {
            Pizza pizza = new Pizza();
            pizza.PizzaID = p.PizzaID;
            pizza.Crust = CrustMapper.CrustDAO_Crust(p.crust);
            pizza.Size = SizeMapper.SizeDAO_Size(p.size);
            pizza.Sauce = SauceMapper.SauceDAO_Sauce(p.sauce);
            return pizza;
        }

        public static List<Topping> PizzaDAO_Topping(PizzaDAO p)
        {
            List<Topping> t = new List<Topping>();
            foreach (var item in p.toppings)
            {
                t.Add(ToppingMapper.ToppingDAO_Topping(item));
            }
            return t;
        }

        public static List<Cheese> PizzaDAO_Cheeses(PizzaDAO p)
        {
            List<Cheese> c = new List<Cheese>();
            foreach (var item in p.cheeses)
            {
                c.Add(CheeseMapper.CheeseDAO_Cheese(item));
            }
            return c;
        }
    }
}