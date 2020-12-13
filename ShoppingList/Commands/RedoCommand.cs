using System.Collections.Generic;

namespace ShoppingList.Commands
{
    public class RedoCommand : ICommand
    {
        public void Execute(Stack<Product> products, Product newProduct = null)
        {
            products.Push(products.Peek());
        }
    }
}
