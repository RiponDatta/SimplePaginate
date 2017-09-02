using System;
using System.Linq;

namespace SimplePaginate
{
    public static class SimplePaginateService
    {
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            var result = new Page<T>
            {
                CurrentPage = pageNumber,
                PageSize = pageSize,
                RecordCount = query.Count(),
                Results = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };
            result.PageCount = (int)Math.Ceiling((double)result.RecordCount / pageSize);
            return result;
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Filters<T> filters)
        {
            return query.ApplyFilter(filters).SimplePaginate(pageNumber, pageSize);
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Sorts<T> sorts)
        {
            return query.ApplySort(sorts).SimplePaginate(pageNumber, pageSize);
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Filters<T> filters, Sorts<T> sorts)
        {
            return query.ApplyFilter(filters).SimplePaginate(pageNumber, pageSize, sorts);
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Groups<T> groups)
        {
            return query.SimplePaginateWithGrouping(groups, pageNumber, pageSize);
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Filters<T> filters, Groups<T> groups)
        {
            return query.ApplyFilter(filters).SimplePaginateWithGrouping(groups, pageNumber, pageSize);
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Sorts<T> sorts, Groups<T> groups)
        {
            return query.ApplySort(sorts).SimplePaginateWithGrouping(groups, pageNumber, pageSize);
        }
        public static Page<T> SimplePaginate<T>(this IQueryable<T> query, int pageNumber, int pageSize, Filters<T> filters, Sorts<T> sorts, Groups<T> groups)
        {
            return query.ApplyFilter(filters).ApplySort(sorts).SimplePaginateWithGrouping(groups, pageNumber, pageSize);
        }
        #region Private members
        private static IQueryable<T> ApplyFilter<T>(this IQueryable<T> query, Filters<T> filters)
        {
            if (!filters.HasAny()) return query;
            IQueryable<T> result = query;
            foreach (var filter in filters.Get())
            {
                result = result.Where(filter.Expression);
            }
            return result;
        }
        private static IQueryable<T> ApplySort<T>(this IQueryable<T> query, Sorts<T> sorts)
        {
            if (!sorts.HasAny()) return query;
            var sort = sorts.Get();
            return Sorts<T>.ApplySort(query, sort);
        }
        private static Page<T> SimplePaginateWithGrouping<T>(this IQueryable<T> query, Groups<T> groups, int pageNumber, int pageSize)
        {
            var result = new Page<T>();
            if (groups.HasAny())
            {
                foreach (var group in groups.Get())
                {
                    result = Groups<T>.ApplyGroup(query, group, pageNumber, pageSize);
                    break;
                }
            }
            else
            {
                result = SimplePaginate(query, pageNumber, pageSize);
            }
            return result;
        }
        #endregion Private members
    }
}