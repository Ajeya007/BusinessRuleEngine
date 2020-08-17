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
    }
}
