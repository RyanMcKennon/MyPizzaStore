using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.DataAccess
{
    public partial class EfOperations
    {
        public bool DeleteOrder(PizzaOrder o)
        {
            var po = db.PizzaOrders.Where(x => x.PizzaOrderID == o.PizzaOrderID).FirstOrDefault();
            List<Order> order = db.Orders.Where(x => x.PizzaOrderID == o.PizzaOrderID).ToList();
            Pizza pizza = new Pizza();
            foreach (var item in order)
            {
                pizza = db.Pizzas.Where(x => x.PizzaID == item.PizzaID).FirstOrDefault();
                db.Pizzas.Remove(pizza);
            }
            db.PizzaOrders.Remove(po);
            return db.SaveChanges() > 0;
        }
    }
}
