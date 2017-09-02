using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SimplePaginate
{
    public class Filters<T>
    {
        private readonly List<Filter<T>> _filterList;
        public Filters()
        {
            _filterList = new List<Filter<T>>();
        }

        public void Add(Expression<Func<T, bool>> expression)
        {
            _filterList.Add(new Filter<T>
            {
                Expression = expression
            });
        }

        internal bool HasAny()
        {
            return _filterList.Any();
        }

        internal List<Filter<T>> Get()
        {
            return _filterList.ToList();
        }
    }
}