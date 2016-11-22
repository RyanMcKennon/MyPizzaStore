using PizzaStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.ViewModel
{
    public class PizzaStoreModel
    {
        public List<PizzaOrderDAO> History { get; set; }
        public PizzaOrderDAO PizzaOrder { get; set; }
        public OrderDAO Order { get; set; }
        public CustomerDAO Customer { get; set; }
        public NameDAO Name { get; set; }
        public NumberDAO Number { get; set; }
        public EmailDAO Email { get; set; }
        public AddressDAO Address { get; set; }
        public PizzaDAO Pizza { get; set; }
        public CrustDAO Crust { get; set; }
        public SauceDAO Sauce { get; set; }
        public SizeDAO Size { get; set; }
        public ToppingDAO Topping { get; set; }
        public CheeseDAO Cheese { get; set; }
        public List<CheeseDAO> ListOfCheeses { get; set; }
        public List<ToppingDAO> ListOfTopping { get; set; }
        public List<CrustDAO> ListOfCrusts { get; set; }
        public SelectListItem SelectedCrust { get; set; }
        public List<SizeDAO> ListOfSizes { get; set; }
        public SelectListItem SelectedSize { get; set; }
        public List<SauceDAO> ListOfSauces { get; set; }
        public SelectListItem SelectedSauce { get; set; }

        public PizzaStoreModel()
        {
            PizzaOrder = new PizzaOrderDAO();
            PizzaOrder.Order = new OrderDAO();
            PizzaOrder.Order.Pizzas = new List<PizzaDAO>();
            Customer = new CustomerDAO();
            History = new List<PizzaOrderDAO>();
        }
    }

}