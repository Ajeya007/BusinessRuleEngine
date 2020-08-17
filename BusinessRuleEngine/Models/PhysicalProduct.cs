using BusinessRuleEngine.PaymentHelpers;

namespace BusinessRuleEngine.Models
{
    public class PhysicalProduct : Product
    {
        public override int ProductId
        {
            get { return 1; }
            set { }
        }

        public override string ProductName 
        { 
            get => "Physical product";
            set { } 
        }

        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for {this.ProductName}(Id:{this.ProductId})");
            System.Console.WriteLine(this.GeneratePackingSlip());
            System.Console.WriteLine(this.GenerateCommissionPayment());
            isSuccess = true;
            System.Console.WriteLine();
        }
    }
}
