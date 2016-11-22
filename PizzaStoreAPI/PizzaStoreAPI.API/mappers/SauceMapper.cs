using PizzaStoreAPI.API.Models;
using PizzaStoreAPI.API.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.mappers
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