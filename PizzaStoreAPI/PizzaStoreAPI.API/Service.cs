using PizzaStoreAPI.API.mappers;
using PizzaStoreAPI.API.Models;
using PizzaStoreAPI.API.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API
{
    public class Service
    {
        private Service1Client svc = new Service1Client();

        public List<SauceDTO> GetSauces()
        {
            List<SauceDTO> sauces = new List<SauceDTO>();
            foreach (var item in svc.GetSauces())
            {
                sauces.Add(SauceMapper.SauceDAO_SauceDTO(item));
            }
            return sauces;
        }

        public List<ToppingDTO> GetToppings()
        {
            List<ToppingDTO> toppings = new List<ToppingDTO>();
            foreach (var item in svc.GetToppings())
            {
                toppings.Add(ToppingMapper.ToppingDAO_ToppingDTO(item));
            }
            return toppings;
        }

        public List<CrustDTO> GetCrusts()
        {
            List<CrustDTO> crusts = new List<CrustDTO>();
            foreach (var item in svc.GetCrusts())
            {
                crusts.Add(CrustMapper.CrustDAO_CrustDTO(item));
            }
            return crusts;
        }

        public List<SizeDTO> GetSizes()
        {
            List<SizeDTO> sizes = new List<SizeDTO>();
            foreach (var item in svc.GetSizes())
            {
                sizes.Add(SizeMapper.SizeDAO_SizeDTO(item));
            }
            return sizes;
        }

        public List<CheeseDTO> GetCheeses()
        {
            List<CheeseDTO> cheeses = new List<CheeseDTO>();
            foreach (var item in svc.GetCheeses())
            {
                cheeses.Add(CheeseMapper.CheeseDAO_CheeseDTO(item));
            }
            return cheeses;
        }

        public void InsertCustomer(CustomerDTO c)
        {
            svc.InsertCustomer(c);
        }

        
    }
}