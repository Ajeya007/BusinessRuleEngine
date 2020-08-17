namespace BusinessRuleEngine.Models
{
    public abstract class Product
    {
        public abstract int ProductId { get; set; }
        public abstract string ProductName { get; set; }
        public abstract void TryProcessPayment(out bool isSuccess);
    }
}
