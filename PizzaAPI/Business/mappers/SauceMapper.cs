using Business.models;
using Business.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.mappers
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
    }
}
