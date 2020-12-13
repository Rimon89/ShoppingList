using ShoppingList.Contracts;

namespace ShoppingList.Payment
{
    public class MasterCard : IPayment
    {
        public string Payment()
        {
            return "Payment: MasterCard (Debit)";
        }
    }
}
