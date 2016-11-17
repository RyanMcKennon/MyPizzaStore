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
            pizza.Crust = p.crust;
            pizza.Size = p.size;
            pizza.Sauce = p.sauce;
            return pizza;
        }

        public static List<Topping> PizzaDAO_Topping(PizzaDAO p)
        {
            List<Topping> t = new List<Topping>();
            t = p.toppings;
            return t;
        }

        public static List<Cheese> PizzaDAO_Cheeses(PizzaDAO p)
        {
            List<Cheese> c = new List<Cheese>();
            c = p.cheeses;
            return c;
        }
    }
}