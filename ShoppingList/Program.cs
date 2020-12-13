using ShoppingList.Contracts;
using ShoppingList.Events;
using ShoppingList.Factory;
using ShoppingList.Filter;
using ShoppingList.Filter.Specification;
using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.ChosenCommand += NotifyChosenCommand;

            user.SetCommandOption(1 /*Add command*/);
            user.SetProduct(new Product("Dining table", 1500, "Home", "Brown", 1));
            user.RunCommand();

            user.ShowOrder();

            user.SetCommandOption(1 /*Add command*/);
            user.SetProduct(new Product("Dishwasher", 6000, "Kitchen", "Silver", 1));
            user.RunCommand();

            user.ShowOrder();

            user.SetCommandOption(1 /*Add command*/);
            user.SetProduct(new Product("Toaster", 900, "Kitchen", "Silver", 1));
            user.RunCommand();

            user.ShowOrder();

            user.SetCommandOption(2 /*Redo command*/);
            user.RunCommand();

            user.ShowOrder();

            user.SetCommandOption(3 /*Undo command*/);
            user.RunCommand();

            var listOfProducts = user.ShowOrder();

            SetPayment("Debit", "Maestro");

            FilterList(listOfProducts, "Color", "Silver");

            Console.ReadLine();
        }

        private static void NotifyChosenCommand(object sender, ChosenCommandEventArgs e)
        {
            Console.WriteLine(e.message);
        }

        private static void SetPayment(string paymentType, string bankCard)
        {
            var type = PaymentFactory.CreatePaymentFactory(paymentType);
            var card = type.GetPayment(bankCard);
            Console.WriteLine(card.Payment() + "\n----------------------------------");
        }

        private static void FilterList(IEnumerable<Product> products, string searchBy, string searchKey)
        {
            ISpecification<Product> spec = null;
            var productFilter = new ProductFilter();

            switch (searchBy.ToLower())
            {
                case "category":
                    spec = new CategorySpecification(searchKey);
                    break;
                case "color":
                    spec = new ColorSpecification(searchKey);
                    break;
            }
            Console.WriteLine("\n---------Filtered List------------\n");

            foreach (var item in productFilter.Filter(products, spec))
            {
                Console.WriteLine($"Product: {item.Name}. Category: {item.Category}. Color: {item.Color}");
            }

            Console.WriteLine("\n---------End of List--------------");
        }
    }
}
