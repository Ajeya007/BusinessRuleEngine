﻿using BusinessRuleEngine.PaymentHelpers;

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

        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for  {this.ProductName}(Id: {this.ProductId})");
            System.Console.WriteLine(this.GeneratePackingSlip());
            System.Console.WriteLine(this.GenerateCommissionPayment());
            isSuccess = true;
            System.Console.WriteLine();
        }
    }
}
