using ShoppingList.Commands;
using ShoppingList.Events;
using System;
using System.Collections.Generic;

namespace ShoppingList
{
    /* The Invoker */
    public class User
    {
        private Product _product;
        private ICommand _command;
        private Order _order;

        public event EventHandler<ChosenCommandEventArgs> ChosenCommand;

        public User()
        {
            _order = new Order();
        }

        public void SetCommandOption(int option)
        {
            string message = null;
            switch (option)
            {
                case 1:
                    message = "Added product to list";
                    break;
                case 2:
                    message = "You choose to redo last added product";
                    break;
                case 3:
                    message = "You choose to undo last added product";
                    break;
                case 4:
                    message = "Why did you do that!?";
                    break;
            }

            ChosenCommand?.Invoke(this, new ChosenCommandEventArgs { message = message });

            _command = CommandFactory.GetCommand(option);
        }

        public void SetProduct(Product product)
        {
            _product = product;
        }

        public void RunCommand()
        {
            _order.RunCommand(_command, _product);
        }

        public IEnumerable<Product> ShowOrder()
        {
            var list = _order.ShowCurrentProducts();
            return list;
        }
    }
}
