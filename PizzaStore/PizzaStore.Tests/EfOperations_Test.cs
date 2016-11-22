using PizzaStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStore.Tests
{
    public class EfOperations_Test
    {
        private EfOperations data = new EfOperations();

        [Fact]
        public void InsertCustomer_Test()
        {
            var expected = 0;
            var actual = data.InsertCustomer(new Customer { }, new Name { FirstName = "Ryan", LastName = "McKennon" },
                                                            new Email { Email1 = "maclet24@yahoo.com"}, new PhoneNumber { PhoneNumber1 = "8708147050"},
                                                            new CustomerAddress {CustomerAddress1 = "123 Jerry Ln" });
            Assert.NotEqual(actual,expected);
        }


        [Fact]
        public void InsertPizzaOrder_Test()
        {
            List<List<Topping>> x = new List<List<Topping>>();
            List<Topping> sublist = new List<Topping>();
            sublist.Add(new Topping { ToppingID = 1 });
            sublist.Add(new Topping { ToppingID = 2 });
            x.Add(sublist);
            List<Topping> sublist2 = new List<Topping>();
            sublist2.Add(new Topping { ToppingID = 2 });
            sublist2.Add(new Topping { ToppingID = 3 });
            x.Add(sublist2);

            List<List<Cheese>> y = new List<List<Cheese>>();
            List<Cheese> sublist3 = new List<Cheese>();
            sublist3.Add(new Cheese { CheeseID = 1 });
            sublist3.Add(new Cheese { CheeseID = 2 });
            y.Add(sublist3);
            List<Cheese> sublist4 = new List<Cheese>();
            sublist4.Add(new Cheese { CheeseID = 2 });
            sublist4.Add(new Cheese { CheeseID = 3 });
            y.Add(sublist4);

            var actual = data.InsertPizzaOrder(new Customer { PhoneNumberID = 1}, 
                new List<Pizza> { new Pizza { CrustID = 1, SauceID = 1, SizeID = 1 }, new Pizza { CrustID = 2, SauceID = 2, SizeID = 3 } },
                x,
                y,
                new Email { Email1 = "bdd@yahoo.com"},
                new Name { FirstName = "Unit2", LastName = "Test2"},
                new PhoneNumber {PhoneNumberID = 19 ,PhoneNumber1 = "12345" },
                new CustomerAddress { CustomerAddress1 = "abc red lane"}
                );

            Assert.True(actual);
        }

        [Fact]
        public void UpdateCustomerName_Test()
        {
            var actual = data.UpdateCustomerName(new Customer { NameId = 1},new Name { FirstName = "RJ", LastName = "MC" });

            Assert.True(actual);
        }

        [Fact]
        public void UpdateCustomerNumber_Test()
        {
            var actual = data.UpdateCustomerNumber(new Customer { PhoneNumberID = 1 }, new PhoneNumber { PhoneNumber1 = "9876543" });

            Assert.True(actual);
        }

        [Fact]
        public void UpdateCustomerEmial_Test()
        {
            var actual = data.UpdateCustomerEmail(new Customer { EmailID = 1 }, new Email { Email1 = "Memes@inc.edu" });

            Assert.True(actual);
        }

        [Fact]
        public void UpdateCustomerAddress_Test()
        {
            var actual = data.UpdateCustomerAddress(new Customer { AddressID = 1 }, new CustomerAddress { CustomerAddress1 = "234 Memes" });

            Assert.True(actual);
        }

        [Fact]
        public void DeletePizzaOrder_Test()
        {
            var actual = data.DeleteOrder(new PizzaOrder { PizzaOrderID = 2, CustomerID = 2 });

            Assert.True(actual);
        }

        [Fact]
        public void GetToppings_Test()
        {
            var actual = data.GetToppingsList();

            Assert.NotNull(actual);
        }

        [Fact]
        public void GetCustomerByID_Test()
        {
            var actual = data.GetCustomer(10);
            Assert.NotNull(actual);
        }

        [Fact]
        public void GetOrderByPizzaOrderID_Test()
        {
            var actual = data.GetOrderByID(3);
            var expected = 2;
            Assert.Equal(actual.Count, expected);
        }

        [Fact]
        public void GetPizzaList_Test()
        {
            var actual = data.GetPizzaList(data.GetOrderByID(3));
            var expected = 2;

            Assert.Equal(actual.Count, expected);
        }

        [Fact]
        public void GetToppingsByPizzaID()
        {
            var actual = data.GetToppingsOnPizza(5);
            var expected = 2;
            Assert.Equal(actual.Count, expected);
        }
    }
}
