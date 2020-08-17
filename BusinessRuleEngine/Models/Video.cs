// <copyright file="Video.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Models
{
    using BusinessRuleEngine.PaymentHelpers;

    /// <summary>
    /// Class for Video product.
    /// </summary>
    public class Video : Product
    {
        /// <summary>
        /// Gets or Sets ProductId.
        /// </summary>
        public override int ProductId
        {
            get { return 5; }
            set { }
        }

        /// <summary>
        /// Gets or Sets ProductName.
        /// </summary>
        public override string ProductName
        {
            get { return "Learning to Ski"; }
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
            isSuccess = true;
            System.Console.WriteLine();
        }
    }
}
