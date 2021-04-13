using System;


namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves one product
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product Class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined product

            //Temporary hard-coded values to return 
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "doggy";
                product.ProductDescription = "A siberian husky stuffed animal";
                product.CurrentPrice = 15.96M;
            }
            Object myObj = new object();
            Console.WriteLine($"Object {myObj.ToString()}");
            Console.WriteLine($"Object {product.ToString()}");
            return product;
        }

        /// <summary>
        /// Saves the current Product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {

            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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