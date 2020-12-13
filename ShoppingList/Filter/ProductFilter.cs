using ShoppingList.Contracts;
using System.Collections.Generic;

namespace ShoppingList.Filter
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.DoesMatch(item))
                {
                    yield return item;
                }
            }
        }
    }
}
