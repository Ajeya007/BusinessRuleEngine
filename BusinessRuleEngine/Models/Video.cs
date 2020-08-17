using BusinessRuleEngine.PaymentHelpers;

namespace BusinessRuleEngine.Models
{
    public class Video : Product
    {
        public override int ProductId
        {
            get { return 5; }
            set { }
        }
        public override string ProductName 
        { 
            get { return "Learning to Ski";} 
            set { } 
        }

        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for  {this.ProductName}(Id: {this.ProductId})");
            this.GeneratePackingSlip();
            isSuccess = true;
        }
    }
}
