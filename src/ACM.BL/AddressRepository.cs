using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        ///<summary>
        /// Retrieve one Address
        ///</summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address Class
            // Pass in the requested id
            Address address = new Address(addressId);

            // code that retrieves the defined address

            // Temporary hard coded values to return
            // a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Kairi Lane";
                address.StreetLine2 = "Kairi Ave";
                address.City = "Mount Olympous";
                address.State = "Speedster flash";
                address.Country = "Country of Kairi";
                address.PostalCode = "1234";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves defined addresses
            // for the customer

            // Temp hard-coded values to return
            // a set of addresses for a customer.

            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                City = "Kairi City",
                Country = "Kairi Country",
                PostalCode = "1222",
                State = "Kairi State",
                StreetLine1 = "Kairi lane",
                StreetLine2 = "555 Kairi Apt"
            };

            addressList.Add(address);

            Address address2 = new Address(2)
            {
                AddressType = 1,
                City = "Andrew City",
                Country = "Andrew Country",
                PostalCode = "1222",
                State = "Andrew State",
                StreetLine1 = "Andrew lane",
                StreetLine2 = "555 Andrew Apt"
            };
            addressList.Add(address2);

            return addressList;
        }

        ///<summary>
        /// Saves one Address
        ///</summary>
        public bool Save(Address address)
        {
            // code that saves an address.
            return true;
        }
    }
}