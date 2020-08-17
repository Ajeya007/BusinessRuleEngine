// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Models
{
    /// <summary>
    /// Abstract class Product.
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        public abstract int ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        public abstract string ProductName { get; set; }

        /// <summary>
        /// Processes payment.
        /// </summary>
        /// <param name="isSuccess">out parameter indcates if the payment process is successful or not.</param>
        public abstract void TryProcessPayment(out bool isSuccess);
    }
}
