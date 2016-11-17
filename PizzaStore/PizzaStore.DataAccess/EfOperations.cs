using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.DataAccess
{
    public partial class EfOperations
    {
        private PizzaStoreDBEntities db = new PizzaStoreDBEntities();

        /// <summary>
        /// Calls methods to insert name, email, phone number, and address and links their ids to a customer and inserts
        /// that customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="number"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public int InsertCustomer(Customer customer,Name name, Email email, PhoneNumber number, CustomerAddress address)
        {
            customer.NameId = InsertName(name);
            customer.EmailID = InsertEmail(email);
            customer.PhoneNumberID = InsertPhoneNumber(number);
            customer.AddressID = InsertAddress(address);
            db.Customers.Add(customer);
            db.SaveChanges();
            db.Entry(customer).GetDatabaseValues();
            return customer.CustomerID;
        }

        /// <summary>
        /// inserts a name into the database and returns the id of the name inserted
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int InsertName(Name name)
        {
            db.Names.Add(name);
            db.SaveChanges();
            db.Entry(name).GetDatabaseValues();
            int id = name.NameID;
            return id;
        }
            
        /// <summary>
        /// Inserts the email and returns the id of the email inserted
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int InsertEmail(Email email)
        {
            db.Emails.Add(email);
            db.SaveChanges();
            db.Entry(email).GetDatabaseValues();
            int id = email.EmailID;
            return id;
        }

        /// <summary>
        /// Inserts a phone number and returns the ID of the number inserted
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int InsertPhoneNumber(PhoneNumber number)
        {
            db.PhoneNumbers.Add(number);
            db.SaveChanges();
            db.Entry(number).GetDatabaseValues();
            int id = number.PhoneNumberID;
            return id;
        }

        /// <summary>
        /// Inserting the address and returns the ID of the address inserted
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public int InsertAddress(CustomerAddress address)
        {
            db.CustomerAddresses.Add(address);
            db.SaveChanges();
            db.Entry(address).GetDatabaseValues();
            int id = address.AddressID;
            return id;
        }

        public bool InsertPizzaOrder(Customer customer, List<Pizza> pizza, List<List<Topping>> topping, List<List<Cheese>> cheeses, Email email, Name name, PhoneNumber number, CustomerAddress address)
        {
            PizzaOrder pizzaorder = new PizzaOrder();
            Customer result =  db.Customers.Where(x => x.PhoneNumberID == number.PhoneNumberID).FirstOrDefault();
            if (result != null )
            {
                pizzaorder.CustomerID = result.CustomerID;
            }
            else
            {
                pizzaorder.CustomerID = InsertCustomer(customer, name, email, number, address);
            }
            db.PizzaOrders.Add(pizzaorder);
            db.SaveChanges();
            db.Entry(pizzaorder).GetDatabaseValues();
            int pizzaOrderID = pizzaorder.PizzaOrderID;

            for(int i=0; i< pizza.Count; i++)
            {
                InsertOrder(pizzaOrderID, pizza[i], topping[i], cheeses[i]);
            }
            return true;
        }

        public void InsertOrder(int PizzaOrderID, Pizza pizza, List<Topping> toppings, List<Cheese> cheeses)
        {
            Order order = new Order();
            int pizzaID = AddPizza(pizza, toppings, cheeses);
            order.PizzaID = pizzaID;
            order.PizzaOrderID = PizzaOrderID;
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public int AddPizza(Pizza pizza, List<Topping> toppings, List<Cheese> cheese)
        {
            int id = InsertPizza(pizza);
            InsertToppings(id, toppings);
            InsertCheeses(id, cheese);
            return id;
        }

        public int InsertPizza(Pizza pizza)
        {
            db.Pizzas.Add(pizza);
            db.SaveChanges();
            db.Entry(pizza).GetDatabaseValues();
            return pizza.PizzaID;
        }

        public void InsertToppings(int PizzaID, List<Topping> toppings)
        {
            PizzaTopping pizzatoppings = new PizzaTopping();
            foreach (var item in toppings)
            {
                pizzatoppings.PizzaID = PizzaID;
                pizzatoppings.ToppingID = item.ToppingID;
                db.PizzaToppings.Add(pizzatoppings);
                db.SaveChanges();
            }
            
        }

        public void InsertCheeses(int PizzaID, List<Cheese> cheeses)
        {
            PizzaChees pizzacheese = new PizzaChees();
            foreach (var item in cheeses)
            {
                pizzacheese.PizzaID = PizzaID;
                pizzacheese.CheeseID = item.CheeseID;
                db.PizzaCheeses.Add(pizzacheese);
                db.SaveChanges();
            }
        }
    }
}
