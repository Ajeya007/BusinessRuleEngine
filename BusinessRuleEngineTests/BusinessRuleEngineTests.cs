namespace BusinessRuleEngineTests
{
    using BusinessRuleEngine.Models;
    using Xunit;

    public class BusinessRuleEngineTests
    {

        [Fact]
        public void Test_PhysicalProduct_ProcessPayment()
        {
            Product product = new PhysicalProduct();
            product.TryProcessPayment(out bool isSuccess);
            Assert.True(isSuccess);
        }

        [Fact]
        public void Test_BookProduct_ProcessPayment()
        {
            Product product = new Book();
            product.TryProcessPayment(out bool isSuccess);
            Assert.True(isSuccess);
        }

        [Fact]
        public void Test_VideoProduct_ProcessPayment()
        {
            Product product = new Video();
            product.TryProcessPayment(out bool isSuccess);
            Assert.True(isSuccess);
        }

        [Fact]
        public void Test_MembershipCreateProduct_ProcessPayment()
        {
            Product product = new MembershipCreate();
            product.TryProcessPayment(out bool isSuccess);
            Assert.True(isSuccess);
        }

        [Fact]
        public void Test_MembershipUpgradeProduct_ProcessPayment()
        {
            Product product = new MembershipUpgrade();
            product.TryProcessPayment(out bool isSuccess);
            Assert.True(isSuccess);
        }
    }
}
