using PizzaStore.Client.Models;
using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Client.Mappers
{
    public class CustomerMapper
    {
        public static Customer CustomerDAO_Customer(CustomerDAO customer)
        {
            Customer c = new Customer();
            c.CustomerID = customer.CustomerID;
            c.EmailID = customer.email.EmailID;
            c.NameId = customer.name.NameID;
            c.PhoneNumberID = customer.number.PhoneNumberID;
            c.AddressID = customer.address.AddressID;
            return c;
        }

        public static Name CustomerDAO_Name(CustomerDAO c)
        {
            var name = new Name();
            name.NameID = c.name.NameID;
            name.FirstName = c.name.FirstName;
            name.LastName = c.name.LastName;
            return name;
        }

        public static Email CustomerDAO_Email(CustomerDAO c)
        {
            var email = new Email();
            email.EmailID = c.email.EmailID;
            email.Email1 = c.email.Email1;
            return email;
        }

        public static PhoneNumber CustomerDAO_PhoneNumber(CustomerDAO c)
        {
            var number = new PhoneNumber();
            number.PhoneNumberID = c.number.PhoneNumberID;
            number.PhoneNumber1 = c.number.PhoneNumber1;
            return number;
        }

        public static CustomerAddress CustomerDAO_CustomerAddress(CustomerDAO c)
        {
            var address = new CustomerAddress();
            address.AddressID = c.address.AddressID;
            address.CustomerAddress1 = c.address.CustomerAddress1;
            return address;
        }
    }
}