using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SimplePaginate
{
    public class Groups<T>
    {
        private readonly List<dynamic> _groupList;

        public Groups()
        {
            _groupList = new List<dynamic>();
        }

        public void Add<TKey>(Expression<Func<T, TKey>> expression)
        {
            _groupList.Add(new Group<T, TKey>
            {
                Expression = expression
            });
        }

        internal bool HasAny()
        {
            return _groupList.Any();
        }

        internal dynamic Get()
        {
            return _groupList.ToList();
        }
        internal dynamic First()
        {
            return _groupList.FirstOrDefault();
        }
        internal static Page<T> ApplyGroup<TKey>(IQueryable<T> query, Group<T, TKey> group, int pageNumber, int pageSize)
        {
            var groupedItems = query.GroupBy(group.Expression).Select(x => new {Key = x.Key, Items = x.ToList()});
            var result = new Page<T>
            {
                CurrentPage = pageNumber,
                PageSize = pageSize,
                RecordCount = groupedItems.Count(),
                Results = groupedItems.ToList().Skip((pageNumber - 1) * pageSize).Take(pageSize).SelectMany(x => x.Items).ToList()
            };
            return result;
        }
    }
}
