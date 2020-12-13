using ShoppingList.Contracts;
using ShoppingList.Payment;

namespace ShoppingList.Factory.ConcreteFactory
{
    public class DebitFactory : PaymentFactory
    {
        public override IPayment GetPayment(string paymentType)
        {
            if (paymentType.ToLower() == "mastercard")
            {
                return new MasterCard();
            }
            else if (paymentType.ToLower() == "maestro")
            {
                return new Maestro();
            }

            return null;
        }
    }
}
