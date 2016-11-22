using PizzaStoreAPI.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class CheeseMapper
    {
        public static CheeseDAO Cheese_CheeseDAO(Cheese c)
        {
            CheeseDAO cheese = new CheeseDAO();
            cheese.ID = c.CheeseID;
            cheese.Name = c.Name;
            return cheese;
        }

        public static Cheese CheeseDAO_Cheese(CheeseDAO c)
        {
            Cheese cheese = new Cheese();
            cheese.CheeseID = c.ID;
            cheese.Name = c.Name;
            return cheese;
        }
    }
}