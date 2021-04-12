using System;
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
    }
}