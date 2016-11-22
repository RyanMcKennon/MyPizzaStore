using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.models
{
    public class CustomerDTO
    {
        public int ID { get; set; }
        public NameDTO name {get;set; }
        public NumberDTO phoneNumber { get; set; }
        public EmailDTO email { get; set; }
        public AddressDTO Address { get; set; }
    }
}
