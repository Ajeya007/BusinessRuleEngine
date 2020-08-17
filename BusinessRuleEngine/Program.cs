// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BusinessRuleEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BusinessRuleEngine.Exceptions;
    using BusinessRuleEngine.Models;

    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Master set Products.
        /// </summary>
        public static readonly List<Product> Products = new List<Product>();

        /// <summary>
        /// Products chosen whose payment needs to be processed.
        /// </summary>
        public static readonly List<Product> PaidProducts = new List<Product>();

        /// <summary>
        /// Entry point of execution.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("---Welcome to Business Rule Engine---");
            InitializeProducts();

            while (true)
            {
                try
                {
                    PromptInput();
                    var productChosen = GetValidatedProduct(out bool isPaymentComplete);
                    if (isPaymentComplete)
                    {
                        break;
                    }

                    PaidProducts.Add(productChosen);
                }
                catch (InvalidProductException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            foreach (var product in PaidProducts)
            {
                product.TryProcessPayment(out bool isSuccess);
                if (!isSuccess)
                {
                    // Throw exception with message. Continue processing other payments.
                }
            }

            Console.ReadLine();
        }

        private static void PromptInput()
        {
            Console.WriteLine("---Make payment for below products. (Choose a product by pressing the id infront of it.)---");
            Console.WriteLine("Press 0 to stop selecting products and complete the payment");
            Console.WriteLine();
            Console.WriteLine("---------------------");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.ProductId} : {product.ProductName}");
            }

            Console.WriteLine("---------------------");
            Console.WriteLine();
        }

        private static Product GetValidatedProduct(out bool isPaymentComplete)
        {
            isPaymentComplete = false;

            if (!int.TryParse(Console.ReadLine(), out int productId)
                || (!Products.Any(x => x.ProductId == productId) && productId != 0))
            {
                throw new InvalidProductException("Please choose a valid product");
            }
            else if (productId == 0)
            {
                isPaymentComplete = true;
                return null;
            }

            return Products.First(x => x.ProductId == productId);
        }

        private static void InitializeProducts()
        {
            Products.Add(new PhysicalProduct());
            Products.Add(new Book());
            Products.Add(new MembershipCreate());
            Products.Add(new MembershipUpgrade());
            Products.Add(new Video());
        }
    }
}
