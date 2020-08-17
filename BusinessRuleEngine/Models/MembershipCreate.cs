using BusinessRuleEngine.PaymentHelpers;

namespace BusinessRuleEngine.Models
{
    public class MembershipCreate : Product
    {
        public override int ProductId
        {
            get { return 3; }
            set { }
        }

        public override string ProductName 
        { 
            get => "Create Membership";
            set { } 
        }

        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for  {this.ProductName}(Id: {this.ProductId})");
            System.Console.WriteLine(this.ActivateMembership());
            System.Console.WriteLine(this.SendEmailToOwner());
            isSuccess = true;
            System.Console.WriteLine();
        }

        private string ActivateMembership()
        {
            return $"Activating membership for {this.ProductName}(Id:{this.ProductId})";
        }
    }
}
