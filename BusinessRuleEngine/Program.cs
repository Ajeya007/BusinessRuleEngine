using BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BusinessRuleEngine
{
    public class Program
    {
        static readonly List<Product> products = new List<Product>();
        static readonly List<Product> paidProducts = new List<Product>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Business Rule Engine---");
            InitializeProducts();
            
            while (true)
            {
                PromptInput();
                var productChosen = GetValidatedProduct(out bool isPaymentComplete);
                if (isPaymentComplete)
                {
                    break;
                }
                paidProducts.Add(productChosen);
            }
        }

        private static void PromptInput()
        {            
            Console.WriteLine("---Make payment for below products. (Choose a product by pressing the id infront of it.)---");
            Console.WriteLine("Press 0 to stop selecting products and complete the payment");
            Console.WriteLine();
            Console.WriteLine("---------------------");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductId} : {product.ProductName}" );
            }
            Console.WriteLine("---------------------");
            Console.WriteLine();
        }

        private static Product GetValidatedProduct(out bool isPaymentComplete)
        {
            isPaymentComplete = false;

            if (!int.TryParse(Console.ReadLine(), out int productId)
                || !products.Any(x => x.ProductId == productId)
                )
            {
                throw new Exception("Please choose a valid product");
            }
            else if (productId == 0)
            {
                isPaymentComplete = true;
            }

            return products.First(x => x.ProductId == productId);
        }

        private static void InitializeProducts()
        {
            products.Add( new PhysicalProduct());
            products.Add(new Book());
            products.Add(new MembershipCreate());
            products.Add(new MembershipUpgrade());
            products.Add(new Video());
        }
    }
}
