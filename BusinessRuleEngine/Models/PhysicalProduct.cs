// <copyright file="PhysicalProduct.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Models
{
    using BusinessRuleEngine.PaymentHelpers;

    /// <summary>
    /// PhysicalProduct Class.
    /// </summary>
    public class PhysicalProduct : Product
    {
        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        public override int ProductId
        {
            get { return 1; }
            set { }
        }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        public override string ProductName
        {
            get => "Physical product";
            set { }
        }

        /// <summary>
        /// Processes payment.
        /// </summary>
        /// <param name="isSuccess">out parameter indcates if the payment process is successful or not.</param>
        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for {this.ProductName}(Id:{this.ProductId})");
            System.Console.WriteLine(this.GeneratePackingSlip());
            System.Console.WriteLine(this.GenerateCommissionPayment());
            isSuccess = true;
            System.Console.WriteLine();
        }
    }
}
