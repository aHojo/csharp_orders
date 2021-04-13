using Xunit;

namespace ACM.BL.Test
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "doggy",
                ProductDescription = "A siberian husky stuffed animal",
                CurrentPrice = 15.96M
            };
            //Act
            var actual = productRepository.Retrieve(2);

            // Assert 
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName);
        }
    }
}