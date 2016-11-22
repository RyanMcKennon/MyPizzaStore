using Business.mappers;
using Business.models;
using Business.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class service
    {
        private Service1Client svc = new Service1Client();

        public List<SauceDTO> GetSauces()
        {
            var x = svc.GetSauces();
            List<SauceDTO> sauces = new List<SauceDTO>();
            foreach (var item in x)
            {
                sauces.Add(SauceMapper.SauceDAO_SauceDTO(item));
            }
            return sauces;
        }

    }
}
