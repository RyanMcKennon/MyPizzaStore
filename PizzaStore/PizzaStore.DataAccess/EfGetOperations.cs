using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.DataAccess
{
    public partial class EfOperations
    {
        public List<Topping> GetToppingsList()
        {
            return db.Toppings.ToList();
        }

        public List<Cheese> GetCheesesList()
        {
            return db.Cheese.ToList();
        }

        public List<Size> GetSizesList()
        {
            return db.Sizes.ToList();
        }

        public List<Crust> GetCrustsList()
        {
            return db.Crusts.ToList();
        }

        public List<Sauce> GetSaucesList()
        {
            return db.Sauces.ToList();
        }
    }
}
