using PizzaStoreAPI.API.Models;
using PizzaStoreAPI.API.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.API.mappers
{
    public static class CrustMapper
    {
        public static CrustDTO CrustDAO_CrustDTO(CrustDAO s)
        {
            var e = new CrustDTO();
            e.ID = s.ID;
            e.Name = s.name;
            return e;
        }

        public static CrustDAO CrustDTO_CrustDAO(CrustDTO s)
        {
            var e = new CrustDAO();
            e.ID = s.ID;
            e.name = s.Name;
            return e;
        }
    }
}