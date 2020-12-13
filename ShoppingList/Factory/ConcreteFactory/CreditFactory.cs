using ShoppingList.Contracts;
using ShoppingList.Payment;

namespace ShoppingList.Factory.ConcreteFactory
{
    public class CreditFactory : PaymentFactory
    {
        public override IPayment GetPayment(string paymentType)
        {
            if (paymentType.ToLower() == "visa")
                return new Visa();

            return null;
        }
    }
}
