using System.Collections.Generic;

namespace ShoppingList.Commands
{
    public class ClearCommand : ICommand
    {
        public void Execute(Stack<Product> products, Product newProduct = null)
        {
            products.Clear();
        }
    }
}
