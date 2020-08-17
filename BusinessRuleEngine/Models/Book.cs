namespace BusinessRuleEngine.Models
{
    public class Book : Product
    {
        public override int ProductId
        {
            get { return 2; }
            set { }
        }

        public override string ProductName 
        { 
            get => "Book";
            set { } 
        }
    }
}
