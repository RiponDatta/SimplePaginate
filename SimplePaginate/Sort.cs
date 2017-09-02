using System;
using System.Linq.Expressions;

namespace SimplePaginate
{
    internal class Sort<T, TKey>
    {
        public Expression<Func<T, TKey>> Expression { get; set; }
        public bool ByDescending { get; set; }
    }
}
