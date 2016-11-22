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

        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            var customer = new Customer();
            var temp = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            customer.CustomerID = temp.CustomerID;
            customer.Name = GetCustomerName(int.Parse((temp.NameId).ToString()));
            customer.Email = GetCustomerEmail(int.Parse(temp.EmailID.ToString()));
            customer.PhoneNumber = GetCustomerPhoneNumber(int.Parse(temp.PhoneNumberID.ToString()));
            customer.CustomerAddress = GetCustomerAddress(int.Parse(temp.AddressID.ToString()));
            return customer;
        }

        public Email GetCustomerEmail(int id)
        {
            return db.Emails.Where(x => x.EmailID  == id).FirstOrDefault();
        }

        public PhoneNumber GetCustomerPhoneNumber(int id)
        {
            return db.PhoneNumbers.Where(x => x.PhoneNumberID == id).FirstOrDefault();
        }

        public Name GetCustomerName(int id)
        {
            return db.Names.Where(x => x.NameID == id).FirstOrDefault();
        }

        public CustomerAddress GetCustomerAddress(int id)
        {
            return db.CustomerAddresses.Where(x => x.AddressID == id).FirstOrDefault();
        }

        public List<PizzaOrder> GetPizzaOrders()
        {
            return db.PizzaOrders.ToList();
        }

        public List<PizzaOrder> GetPizzaOrderByCusotomerID(int id)
        {
            return db.PizzaOrders.Where(x => x.CustomerID == id).ToList();
        }

        public PizzaOrder GetPizzaOrderByID(int id)
        {
            return db.PizzaOrders.Where(x => x.PizzaOrderID == id).FirstOrDefault();
        }

        public List<Order> GetOrderByID(int id)
        {
            return db.Orders.Where(x => x.PizzaOrderID == id).ToList();
        }

        public List<Pizza> GetPizzaList(List<Order> orders)
        {
            List<Pizza> pizzas = new List<Pizza>();
            foreach (var item in orders)
            {
                pizzas.Add(db.Pizzas.Where(x => x.PizzaID == item.PizzaID).FirstOrDefault());
            }
            return pizzas;
        }

        public List<Topping> GetToppingsOnPizza(int pizzaID)
        {
            List<Topping> toppings = new List<Topping>();
            var temp = db.PizzaToppings.Where(x => x.PizzaID == pizzaID).ToList();
            foreach (var item in temp)
            {
                toppings.Add(db.Toppings.Where(x => x.ToppingID == item.ToppingID).FirstOrDefault());
            }
            return toppings;
        }

        public List<Cheese> GetCheesesOnPizza(int pizzaID)
        {
            List<Cheese> cheesses = new List<Cheese>();
            var temp = db.PizzaCheeses.Where(x => x.PizzaID == pizzaID).ToList();
            foreach (var item in temp)
            {
                cheesses.Add(db.Cheese.Where(x => x.CheeseID == item.CheeseID).FirstOrDefault());
            }
            return cheesses;
        }

        public Crust GetCrustOnPizza(int crustID)
        {
            return db.Crusts.Where(x => x.CrustID == crustID).FirstOrDefault();
        }

        public Size GetSizeOfPizza(int sizeID)
        {
            return db.Sizes.Where(x => x.SizeID == sizeID).FirstOrDefault();
        }

        public Sauce GetSauceOnPizza(int sauceID)
        {
            return db.Sauces.Where(x => x.SauceID == sauceID).FirstOrDefault();
        }

        public List<PizzaOrder> OrderHistory(int customerID)
        {
            return db.PizzaOrders.Where(x => x.CustomerID == customerID).ToList();
        }
    }
}
