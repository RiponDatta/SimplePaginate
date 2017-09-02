using System;
using System.Linq.Expressions;

namespace SimplePaginate
{
    internal class Filter<T>
    {
        public Expression<Func<T, bool>> Expression { get; set; }
    }
}