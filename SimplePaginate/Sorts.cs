using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SimplePaginate
{
    public class Sorts<T>
    {
        private readonly List<dynamic> _sortList;

        public Sorts()
        {
            _sortList = new List<dynamic>();
        }

        public void Add<TKey>(Expression<Func<T, TKey>> expression, bool byDescending = false)
        {
            _sortList.Add(new Sort<T, TKey>
            {
                Expression = expression,
                ByDescending = byDescending
            });
        }

        internal bool HasAny()
        {
            return _sortList.Any();
        }

        internal dynamic Get()
        {
            return _sortList.FirstOrDefault();
        }

        internal static IQueryable<T> ApplySort<TKey>(IQueryable<T> query, Sort<T, TKey> sort)
        {
            return sort.ByDescending
                ? query.OrderByDescending(sort.Expression)
                : query.OrderBy(sort.Expression);
        }
    }
}