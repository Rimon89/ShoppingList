﻿using System.Collections.Generic;

namespace ShoppingList.Contracts
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
