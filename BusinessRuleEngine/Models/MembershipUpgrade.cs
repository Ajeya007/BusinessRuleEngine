using BusinessRuleEngine.PaymentHelpers;

namespace BusinessRuleEngine.Models
{
    public class MembershipUpgrade : Product
    {
        public override int ProductId
        {
            get { return 4; }
            set { }
        }

        public override string ProductName 
        { 
            get => "Upgrade Membership";
            set { }
        }

        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for  {this.ProductName}(Id: {this.ProductId})");
            System.Console.WriteLine(this.UpgradeMembership());
            System.Console.WriteLine(this.SendEmailToOwner());
            isSuccess = true;
            System.Console.WriteLine();
        }

        private string UpgradeMembership()
        {
            return $"Applying membership upgrade for {this.ProductName}(Id:{this.ProductId})";
        }
    }
}
