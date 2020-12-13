using ShoppingList.Contracts;

namespace ShoppingList.Filter.Specification
{
    public class CategorySpecification : ISpecification<Product>
    {
        private string category;

        public CategorySpecification(string category)
        {
            this.category = category;
        }
        public bool DoesMatch(Product product)
        {
            return product.Category == category;
        }
    }
}
