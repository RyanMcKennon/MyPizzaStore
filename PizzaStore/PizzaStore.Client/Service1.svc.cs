using PizzaStore.Client.Mappers;
using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PizzaStore.Client
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private EfOperations data = new EfOperations();

        
        public void InsertCustomer(CustomerDAO c)
        {
            data.InsertCustomer(CustomerMapper.CustomerDAO_Customer(c),
                                CustomerMapper.CustomerDAO_Name(c),
                                CustomerMapper.CustomerDAO_Email(c),
                                CustomerMapper.CustomerDAO_PhoneNumber(c),
                                CustomerMapper.CustomerDAO_CustomerAddress(c));
        }

        public void InsertPizzaOrder(PizzaOrderDAO o)
        {
            List<Pizza> p = new List<Pizza>();
            List<List<Topping>> top = new List<List<Topping>>();
            List<List<Cheese>> cheese = new List<List<Cheese>>();
            foreach (var item in o.order.pizzas)
            {
                p.Add(PizzaMapper.PizzaDAO_Pizza(item));
                top.Add(PizzaMapper.PizzaDAO_Topping(item));
                cheese.Add(PizzaMapper.PizzaDAO_Cheeses(item));
            }
            data.InsertPizzaOrder(CustomerMapper.CustomerDAO_Customer(o.customer), p, top, cheese,
                                  CustomerMapper.CustomerDAO_Email(o.customer),
                                  CustomerMapper.CustomerDAO_Name(o.customer),
                                  CustomerMapper.CustomerDAO_PhoneNumber(o.customer),
                                  CustomerMapper.CustomerDAO_CustomerAddress(o.customer));
        }

        public List<ToppingDAO> GetToppings()
        {
            var dao = new List<ToppingDAO>();
            var tops = data.GetToppingsList();
            foreach (var item in tops)
            {
                dao.Add(ToppingMapper.Topping_ToppingDAO(item));
            }
            return dao;
        }

        public List<CheeseDAO> GetCheeses()
        {
            var dao = new List<CheeseDAO>();
            var cheese = data.GetCheesesList();
            foreach (var item in cheese)
            {
                dao.Add(CheeseMapper.Cheese_CheeseDAO(item));
            }
            return dao;
        }

        public List<CrustDAO> GetCrusts()
        {
            var dao = new List<CrustDAO>();
            var crust = data.GetCrustsList();
            foreach (var item in crust)
            {
                dao.Add(CrustMapper.Crust_CrustDAO(item));
            }
            return dao;
        }

        public List<SauceDAO> GetSauces()
        {
            var dao = new List<SauceDAO>();
            var sauce = data.GetSaucesList();
            foreach (var item in sauce)
            {
                dao.Add(SauceMapper.Sauce_SauceDAO(item));
            }
            return dao;
        }

        public List<SizesDAO> GetSizes()
        {
            var dao = new List<SizesDAO>();
            var sizes = data.GetSizesList();
            foreach (var item in sizes)
            {
                dao.Add(SizeMapper.Size_SizeDAO(item));
            }
            return dao;
        }

        public void UpdateCustomerEmail()
        {

        }

    }
}
