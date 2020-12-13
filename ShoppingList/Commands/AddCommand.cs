using System.Collections.Generic;

namespace ShoppingList.Commands
{
    public class AddCommand : ICommand
    {
        public void Execute(Stack<Product> products, Product newProduct)
        {
            products.Push(newProduct);
        }
    }
}
