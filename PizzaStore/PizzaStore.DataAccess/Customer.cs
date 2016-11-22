//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStore.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.PizzaOrders = new HashSet<PizzaOrder>();
        }
    
        public int CustomerID { get; set; }
        public Nullable<int> NameId { get; set; }
        public Nullable<int> EmailID { get; set; }
        public Nullable<int> PhoneNumberID { get; set; }
        public Nullable<int> AddressID { get; set; }
    
        public virtual CustomerAddress CustomerAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
        public virtual Email Email { get; set; }
        public virtual Name Name { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
    }
}