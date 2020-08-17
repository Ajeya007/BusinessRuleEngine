// <copyright file="Book.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Models
{
    using BusinessRuleEngine.PaymentHelpers;

    /// <summary>
    /// Class for Book.
    /// </summary>
    public class Book : Product
    {
        /// <summary>
        /// Gets or Sets Product Id.
        /// </summary>
        public override int ProductId
        {
            get { return 2; }
            set { }
        }

        /// <summary>
        /// Gets or Sets ProductName.
        /// </summary>
        public override string ProductName
        {
            get => "Book";
            set { }
        }

        /// <summary>
        /// Processes payment.
        /// </summary>
        /// <param name="isSuccess">out parameter indcates if the payment process is successful or not.</param>
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
