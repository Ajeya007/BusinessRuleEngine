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
    }
}
