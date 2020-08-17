// <copyright file="InvalidPackageSlipGenerationException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Exceptions
{
    using System;

    /// <summary>
    /// Class for InvalidPackageSlipGenerationException.
    /// </summary>
    public class InvalidPackageSlipGenerationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPackageSlipGenerationException"/> class.
        /// </summary>
        public InvalidPackageSlipGenerationException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPackageSlipGenerationException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public InvalidPackageSlipGenerationException(string message)
            : base(message)
        {
        }
    }
}
