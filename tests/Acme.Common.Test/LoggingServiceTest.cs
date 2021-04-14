using System;
using Xunit;
using System.Collections.Generic;
using ACM.BL;

namespace Acme.Common.Test
{
    public class LoggingServiceTest
    {

        [Fact]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "kairi@dev.to",
                FirstName = "Kairi",
                LastName = "Hojo",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "laptop",
                ProductDescription = "very powerful laptop",
                CurrentPrice = 1000M
            };

            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);




        }
    }
}