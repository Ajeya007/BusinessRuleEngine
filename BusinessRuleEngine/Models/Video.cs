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
    }
}
