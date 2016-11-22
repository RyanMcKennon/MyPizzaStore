using PizzaStore.DataAccess;
using PizzaStoreAPI.mapper;
using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI
{
    public class Service
    {
        private EfOperations data = new EfOperations();

        public List<ToppingDAO> getToppings()
        {
            List<ToppingDAO> toppings = new List<ToppingDAO>();
            foreach (var item in data.GetToppingsList())
            {
                toppings.Add(ToppingMapper.Topping_ToppingDAO(item));
            }
            return toppings;
        }

        public List<SauceDAO> getSauces()
        {
            List<SauceDAO> sauces = new List<SauceDAO>();
            foreach (var item in data.GetSaucesList())
            {
                sauces.Add(SauceMapper.Sauce_SauceDAO(item));
            }
            return sauces;
        }

        public List<CheeseDAO> getCheeses()
        {
            List<CheeseDAO> cheeses = new List<CheeseDAO>();
            foreach (var item in data.GetCheesesList())
            {
                cheeses.Add(CheeseMapper.Cheese_CheeseDAO(item));
            }
            return cheeses;
        }

        public List<CrustDAO> getCrusts()
        {
            List<CrustDAO> crusts = new List<CrustDAO>();
            foreach (var item in data.GetCrustsList())
            {
                crusts.Add(CrustMapper.Crust_CrustDAO(item));
            }
            return crusts;
        }

        public List<SizeDAO> getSizes()
        {
            List<SizeDAO> sizes = new List<SizeDAO>();
            foreach (var item in data.GetSizesList())
            {
                sizes.Add(SizeMapper.Size_SizeDAO(item));
            }
            return sizes;
        }

        public void InsertCustomer(CustomerDAO customer)
        {
            Customer cust = new Customer();
            cust = CustomerMapper.CustomerDAO_Customer(customer);
            data.InsertCustomer(cust, cust.Name, cust.Email, cust.PhoneNumber, cust.CustomerAddress);
        }

        public CustomerDAO GetCustomerByID(int id)
        {
            return CustomerMapper.Customer_CustomerDAO(data.GetCustomer(id));
        }

        public void InsertPizzaOrder(PizzaOrderDAO po)
        {
            List<Pizza> Pizza = new List<Pizza>();
            List < List < Topping >> toppings = new List<List<Topping>>();
            List<List<Cheese>> cheeses = new List<List<Cheese>>();
            foreach (var item in po.Order.Pizzas)
            {
                Pizza.Add(PizzaMapper.PizzaDAO_Pizza(item));
                toppings.Add(PizzaMapper.PizzaDAO_Topping(item));
                cheeses.Add(PizzaMapper.PizzaDAO_Cheeses(item));
            }

            data.InsertPizzaOrder(CustomerMapper.CustomerDAO_Customer(po.Customer), Pizza,toppings,cheeses,
                                  EmailMapper.EmailDAO_Email(po.Customer.Email),
                                  NameMapper.NameDAO_Name(po.Customer.Name),
                                  NumberMapper.NumberDAO_Number(po.Customer.Number),
                                  AddressMapper.AddressDAO_Address(po.Customer.Address));
        }


        public PizzaOrderDAO GetPizzaOrder(int id)
        {
            PizzaOrderDAO po = new PizzaOrderDAO();
            PizzaOrder temppo = new PizzaOrder();
            List<Order>temporder = new List<Order>();
            List<Pizza> temppizzas = new List<Pizza>();
            List<PizzaDAO> temppizzaDAO = new List<PizzaDAO>();


            temppo = data.GetPizzaOrderByID(id);
            po.ID = temppo.PizzaOrderID;
            po.Customer = GetCustomerByID(int.Parse(temppo.CustomerID.ToString()));
            temporder = data.GetOrderByID(po.ID);
            temppizzas = data.GetPizzaList(temporder);

            foreach (var item in temppizzas)
            {
                var tempToppings = data.GetToppingsOnPizza(int.Parse(item.PizzaID.ToString()));
                var tempCheeses = data.GetCheesesOnPizza(int.Parse(item.PizzaID.ToString()));
                var tempToppingsDAO = new List<ToppingDAO>();
                var tempCheesesDAO = new List<CheeseDAO>();

                foreach (var i in tempToppings)
                {
                    tempToppingsDAO.Add(ToppingMapper.Topping_ToppingDAO(i));   
                }
                foreach (var y in tempCheeses)
                {
                    tempCheesesDAO.Add(CheeseMapper.Cheese_CheeseDAO(y));
                }


                var t = new PizzaDAO
                {
                    ID = item.PizzaID,
                    Crust = CrustMapper.Crust_CrustDAO(data.GetCrustOnPizza(int.Parse(item.CrustID.ToString()))),
                    Sauce = SauceMapper.Sauce_SauceDAO(data.GetSauceOnPizza(int.Parse(item.SauceID.ToString()))),
                    Size = SizeMapper.Size_SizeDAO(data.GetSizeOfPizza(int.Parse(item.SizeID.ToString()))),
                    Toppings = tempToppingsDAO,
                    Cheeses = tempCheesesDAO
                };

                temppizzaDAO.Add(t);
            }
            OrderDAO order = new OrderDAO();
            order.Pizzas = temppizzaDAO;
            po.Order = order;

            return po;
        }

        public List<PizzaOrderDAO> CustomerOrderHistory(int customerID)
        {
            var history = data.OrderHistory(customerID);
            List<PizzaOrderDAO> orders = new List<PizzaOrderDAO>();
            foreach (var item in history)
            {
                orders.Add(GetPizzaOrder(item.PizzaOrderID));
            }
            return orders;
        }


    }
}