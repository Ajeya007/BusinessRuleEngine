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
    }
}
