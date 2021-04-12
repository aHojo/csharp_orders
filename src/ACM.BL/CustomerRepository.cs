using System;


namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieves one customer
        /// </summary>
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
            }
            return customer;
        }

        /// <summary>
        /// Saves the current Customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            //code that saves the passed in customer
            return true;
        }
    }
}