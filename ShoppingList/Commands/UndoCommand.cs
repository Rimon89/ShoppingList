using System;
using System.Collections.Generic;

namespace ShoppingList.Commands
{
    public class UndoCommand : ICommand
    {
        public void Execute(Stack<Product> products, Product newProduct = null)
        {
            if(products.Count > 0)
            {
                products.Pop();
            }
            else
            {
                Console.WriteLine("There is no items to remove.");
            }
        }
    }
}
