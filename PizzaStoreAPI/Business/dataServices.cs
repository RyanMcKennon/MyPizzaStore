using Business.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class dataServices
    {
        private Service1Client svc = new Service1Client();

        public string GetToppingDAO()
        {
            var x = svc.GetToppings();
            return x[0].Name;
        }
    }
}
