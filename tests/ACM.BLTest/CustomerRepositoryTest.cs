using System;
using System.Collections.Generic;
using Xunit;

namespace ACM.BL.Test
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "kairihojo@gmail.com",
                FirstName = "Kairi",
                LastName = "Hojo"
            };
            //Act
            var actual = customerRepository.Retrieve(1);

            // Assert 
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "kairihojo@gmail.com",
                FirstName = "Kairi",
                LastName = "Hojo",
                AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        City = "Kairi City",
                        Country = "Kairi Country",
                        PostalCode = "1222",
                        State = "Kairi State",
                        StreetLine1 = "Kairi lane",
                        StreetLine2 = "555 Kairi Apt"
                    },
                    new Address(2)
                    {
                        AddressType = 1,
                        City = "Andrew City",
                        Country = "Andrew Country",
                        PostalCode = "1222",
                        State = "Andrew State",
                        StreetLine1 = "Andrew lane",
                        StreetLine2 = "555 Andrew Apt"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}