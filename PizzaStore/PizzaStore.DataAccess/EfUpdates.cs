using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.DataAccess
{
    public partial class EfOperations
    {
        public bool UpdateCustomerNumber(Customer c, PhoneNumber p)
        {
            var result = db.PhoneNumbers.Where(x => x.PhoneNumberID == c.PhoneNumberID).FirstOrDefault();
            result.PhoneNumber1 = p.PhoneNumber1;
            return db.SaveChanges() > 0;
        }

        public bool UpdateCustomerEmail(Customer c, Email e)
        {
            var result = db.Emails.Where(x => x.EmailID == c.EmailID).FirstOrDefault();
            result.Email1 = e.Email1;
            return db.SaveChanges() > 0;
        }

        public bool UpdateCustomerAddress(Customer c, CustomerAddress a)
        {
            var result = db.CustomerAddresses.Where(x => x.AddressID == c.AddressID).FirstOrDefault();
            result.CustomerAddress1 = a.CustomerAddress1;
            return db.SaveChanges() > 0;
        }

        public bool UpdateCustomerName(Customer c, Name n)
        {
            var result = db.Names.Where(x => x.NameID == c.NameId).FirstOrDefault();
            result.FirstName = n.FirstName;
            result.LastName = n.LastName;
            return db.SaveChanges() > 0;
        }
    }
}
