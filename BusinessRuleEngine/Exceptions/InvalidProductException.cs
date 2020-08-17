// <copyright file="InvalidProductException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine.Exceptions
{
    using System;

    public class InvalidProductException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidProductException"/> class.
        /// </summary>
        public InvalidProductException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidProductException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public InvalidProductException(string message)
            : base(message)
        {
        }
    }
}
