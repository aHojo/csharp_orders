using System;


namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieves one Order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order Class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined Order

            //Temporary hard-coded values to return 
            // a populated Order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Saves the current Order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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