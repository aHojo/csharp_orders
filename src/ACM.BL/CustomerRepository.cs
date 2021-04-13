using System;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Retrieves one customer
        /// </summary>
        // This is a "Uses a" relationship - Collaboration
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer Calss
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined user

            //Temporary hard-coded values to return 
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "kairihojo@gmail.com";
                customer.FirstName = "Kairi";
                customer.LastName = "Hojo";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves the current Customer
        /// </summary>
        /// <returns></returns>
        // This is a "Uses a" relationship
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}