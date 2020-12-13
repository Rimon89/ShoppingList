using ShoppingList.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    /* The Receiver */
    public class Order
    {
        public Stack<Product> listOfproducts { get; set; }

        public Order()
        {
            listOfproducts = new Stack<Product>();
        }

        public void RunCommand(ICommand command, Product product)
        {
            command.Execute(listOfproducts, product);
        }

        public Stack<Product> ShowCurrentProducts()
        {
            foreach (var prod in listOfproducts)
            {
                prod.DisplayProduct();
            }

            if (!listOfproducts.Any())
            {
                Console.WriteLine("\nEmpty shopping list :(\n");
            }

            Console.WriteLine("----------------------------------");

            return listOfproducts;
        }
    }
}