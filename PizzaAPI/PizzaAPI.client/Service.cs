using PizzaAPI.client.Mappers;
using PizzaAPI.client.Models;
using PizzaAPI.client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAPI.client
{
    public class service
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

    }
}
