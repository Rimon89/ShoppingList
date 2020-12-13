using ShoppingList.Contracts;
using ShoppingList.Factory.ConcreteFactory;

namespace ShoppingList.Factory
{
    public abstract class PaymentFactory
    {
        public abstract IPayment GetPayment(string paymentType);

        public static PaymentFactory CreatePaymentFactory(string factoryType)
        {
            if (factoryType.ToLower() == "credit")
                return new CreditFactory();

            return new DebitFactory();
        }
    }
}
