using ShoppingList.Contracts;

namespace ShoppingList.Filter.Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        private string color;

        public ColorSpecification(string color)
        {
            this.color = color;
        }
        public bool DoesMatch(Product product)
        {
            return product.Color == color;
        }
    }
}
