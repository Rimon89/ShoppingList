using ShoppingList.Contracts;

namespace ShoppingList.Payment
{
    public class Visa : IPayment
    {
        public string Payment()
        {
            return "Payment: Visa (Credit)";
        }
    }
}
