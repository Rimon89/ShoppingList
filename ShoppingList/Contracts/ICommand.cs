using System.Collections.Generic;

namespace ShoppingList.Commands
{
    public interface ICommand
    {
        void Execute(Stack<Product> order, Product newProduct);
    }
}
