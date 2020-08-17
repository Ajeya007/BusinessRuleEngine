// <copyright file="PaymentProcess.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.PaymentHelpers
{
    using BusinessRuleEngine.Exceptions;
    using BusinessRuleEngine.Models;

    /// <summary>
    /// Class for common payment process rules.
    /// </summary>
    public static class PaymentProcess
    {
        /// <summary>
        /// Generates Commission Payment.
        /// </summary>
        /// <param name="product">Book object.</param>
        /// <returns>Status message.</returns>
        public static string GenerateCommissionPayment(this Book product)
        {
            return CommissionPaymentProcess(product);
        }

        /// <summary>
        /// Generates Commission Payment.
        /// </summary>
        /// <param name="product">Book object.</param>
        /// <returns>Status message.</returns>
        public static string GenerateCommissionPayment(this PhysicalProduct product)
        {
            return CommissionPaymentProcess(product);
        }

        /// <summary>
        /// Sends Email To Owner.
        /// </summary>
        /// <param name="product">Derivative of Product class.</param>
        /// <returns>Status message.</returns>
        public static string SendEmailToOwner(this MembershipUpgrade product)
        {
            return NotifyOwner(product);
        }

        /// <summary>
        /// Sends Email To Owner.
        /// </summary>
        /// <param name="product">Derivative of Product class.</param>
        /// <returns>Status message.</returns>
        public static string SendEmailToOwner(this MembershipCreate product)
        {
            return NotifyOwner(product);
        }

        /// <summary>
        /// Generates Packing Slip.
        /// </summary>
        /// <param name="product">Derivative of Product class.</param>
        /// <returns>Status message.</returns>
        public static string GeneratePackingSlip(this Product product)
        {
            if (product is PhysicalProduct)
            {
                return $"Generate Packing Slip for {product.ProductName}(Id:{product.ProductId})";
            }
            else if (product is Book)
            {
                return $"Creating a duplicate packing slip for royalty department for {product.ProductName}(Id:{product.ProductId})";
            }
            else if (product is Video && product.ProductName.Equals("Learning to Ski"))
            {
                return $"Adding new \"First Aid\" video to packing slip for {product.ProductName}(Id:{product.ProductId})";
            }
            else
            {
                throw new InvalidPackageSlipGenerationException();
            }
        }

        private static string CommissionPaymentProcess(Product product)
        {
            return $"Generate commission payment to the agent for {product.ProductName}(Id:{product.ProductId})";
        }

        private static string NotifyOwner(Product product)
        {
            if (product is MembershipCreate)
            {
                return $"Send email to owner - Membership Created for {product.ProductName}(Id:{product.ProductId})";
            }
            else
            {
                return $"Send email to owner - Membership Upgraded for {product.ProductName}(Id:{product.ProductId})";
            }
        }
    }
}
