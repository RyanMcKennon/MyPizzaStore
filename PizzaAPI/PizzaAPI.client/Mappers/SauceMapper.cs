using PizzaAPI.client.Models;
using PizzaAPI.client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAPI.client.Mappers
{
    public static class SauceMapper
    {
        public static SauceDTO SauceDAO_SauceDTO(SauceDAO s)
        {
            var sauce = new SauceDTO();
            sauce.ID = s.ID;
            sauce.name = s.name;
            return sauce;
        }

        public static SauceDAO SauceDTO_SauceDAO(SauceDTO s)
        {
            var sauce = new SauceDAO();
            sauce.ID = s.ID;
            sauce.name = s.name;
            return sauce;
        }
    }
}
