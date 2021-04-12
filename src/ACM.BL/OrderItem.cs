using System;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve One OrderItem
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order

            return new OrderItem();
        }


        ///<summary>
        ///Saves the current OrderItem
        ///</summary>
        public bool Save()
        {
            // Code that saves the OrderItem
            return true;
        }

        ///<summary>
        /// Validates the order Data
        ///</summary>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}