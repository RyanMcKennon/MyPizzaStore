using PizzaStore.DataAccess;
using PizzaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.mapper
{
    public static class CustomerMapper
    {
        public static CustomerDAO Customer_CustomerDAO (Customer s)
        {
            var e = new CustomerDAO();
            e.ID = s.CustomerID;
            e.Name = NameMapper.Name_NameDAO(s.Name);
            e.Email = EmailMapper.Email_EmailDAO(s.Email);
            e.Number = NumberMapper.Number_NumberDAO(s.PhoneNumber);
            e.Address = AddressMapper.Address_AddressDAO(s.CustomerAddress);

            return e;
        }

        public static Customer CustomerDAO_Customer(CustomerDAO s)
        {
            var e = new Customer();
            e.CustomerID = s.ID;
            e.Name = NameMapper.NameDAO_Name(s.Name);
            e.Email = EmailMapper.EmailDAO_Email(s.Email);
            e.PhoneNumber = NumberMapper.NumberDAO_Number(s.Number);
            e.CustomerAddress = AddressMapper.AddressDAO_Address(s.Address);
            return e;
        }
    }
}