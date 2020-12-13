using ShoppingList.Contracts;

namespace ShoppingList.Payment
{
    public class Maestro : IPayment
    {
        public string Payment()
        {
            return "Payment: Maestro (Debit)";
        }
    }
}
