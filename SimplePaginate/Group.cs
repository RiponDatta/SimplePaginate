using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimplePaginate
{
    internal class Group<T, TKey>
    {
        public Expression<Func<T, TKey>> Expression { get; set; }
    }

    public class GroupElement<TKey, T>
    {
        public TKey Key { get; set; }
        public List<T> Items { get; set; }
    }
}
