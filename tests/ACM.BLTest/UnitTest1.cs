using System;
using Xunit;

namespace ACM.BL.Test
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Kairi",
                LastName = "Hojo"
            };
            string expected = "Hojo, Kairi";
            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FullNameFirstNameEmptyTest()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Hojo"
            };
            string expected = "Hojo";
            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FullNameLastNameEmptyTest()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Kairi"
            };
            string expected = "Kairi";
            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Kairi";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Andrew";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Lindsay";
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);


        }

        [Fact]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Hojo",
                EmailAddress = "kairi@gmail.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);
        }
    }
}
