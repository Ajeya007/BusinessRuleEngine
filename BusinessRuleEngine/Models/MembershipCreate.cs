// <copyright file="MembershipCreate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Models
{
    using BusinessRuleEngine.PaymentHelpers;

    /// <summary>
    /// Class for MembershipCreate product.
    /// </summary>
    public class MembershipCreate : Product
    {
        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        public override int ProductId
        {
            get { return 3; }
            set { }
        }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        public override string ProductName
        {
            get => "Create Membership";
            set { }
        }

        /// <summary>
        /// Processes payment.
        /// </summary>
        /// <param name="isSuccess">out parameter indcates if the payment process is successful or not.</param>
        public override void TryProcessPayment(out bool isSuccess)
        {
            System.Console.WriteLine($"Processing payment for  {this.ProductName}(Id: {this.ProductId})");
            System.Console.WriteLine(this.ActivateMembership());
            System.Console.WriteLine(this.SendEmailToOwner());
            isSuccess = true;
            System.Console.WriteLine();
        }

        private string ActivateMembership()
        {
            return $"Activating membership for {this.ProductName}(Id:{this.ProductId})";
        }
    }
}
