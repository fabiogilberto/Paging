using System.Collections;
using System.Linq.Expressions;

namespace FabioGilberto.Paging
{
    public class PagedQueryable<T> : IPagedQueryable<T>
    {
        protected IQueryable<T> _innerQuery;

        public PagingPropeties PagingPropeties { get; set; }

        public PagedQueryable(IQueryable<T> query, PagingPropeties pagingPropeties)
        {
            PagingPropeties = pagingPropeties;
            PagingPropeties.TotalCount = query.Count();
            _innerQuery = Paginate(query);
        }

        public Type ElementType => _innerQuery.ElementType;

        public Expression Expression => _innerQuery.Expression;

        public IQueryProvider Provider => _innerQuery.Provider;

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _innerQuery.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _innerQuery.GetEnumerator();
        }

        public IQueryable<T> Paginate(IQueryable<T> query)
        {
            return query.Skip((PagingPropeties.PageIndex - 1)
                * PagingPropeties.PageSize).Take(PagingPropeties.PageSize).AsQueryable();
        }
    }


}