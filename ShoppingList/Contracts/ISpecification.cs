namespace ShoppingList.Contracts
{
    public interface ISpecification<T>
    {
        bool DoesMatch(T type);
    }
}