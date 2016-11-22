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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void InsertCustomer(CustomerDAO c);

        [OperationContract]
        void InsertPizzaOrder(PizzaOrderDAO o);

        [OperationContract]
        List<ToppingDAO> GetToppings();

        [OperationContract]
        List<CheeseDAO> GetCheeses();

        [OperationContract]
        List<CrustDAO> GetCrusts();

        [OperationContract]
        List<SauceDAO> GetSauces();

        [OperationContract]
        List<SizesDAO> GetSizes();

        [OperationContract]
        List<CustomerDAO> GetCustomers();



        //[OperationContract]
        //bool UpdateCustomerNumber(CustomerDAO c, NumberDAO p);
        //[OperationContract]
        //bool UpdateCustomerEmail(Customer c, Email e);
        //[OperationContract]
        //bool UpdateCustomerAddress(Customer c, CustomerAddress a);
        //[OperationContract]
        //bool UpdateCustomerName(CustomerDAO c, NameDAO n);
    }
}
