using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public static class CheeseMapper
    {
        public static CheeseDAO Cheese_CheeseDAO(Cheese c)
        {
            CheeseDAO cheese = new CheeseDAO();
            cheese.ID = c.CheeseID;
            cheese.name = c.Name;
            return cheese;
        }

        public static Cheese CheeseDAO_Cheese(CheeseDAO c)
        {
            Cheese cheese = new Cheese();
            cheese.CheeseID = c.ID;
            cheese.Name = c.name;
            return cheese;
        }
    }
}