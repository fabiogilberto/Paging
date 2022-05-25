using System.Collections;

namespace FabioGilberto.Paging
{
    public class PagedEnumerable<T> : IPagedEnumerable<T>
    {
        protected IEnumerable<T> _innerEnumerable;

        public PagingPropeties PagingPropeties { get; set; }

        public PagedEnumerable(IEnumerable<T> enumerable, PagingPropeties pagingPropeties)
        {
            PagingPropeties = pagingPropeties;
            PagingPropeties.TotalCount = enumerable.Count();
            _innerEnumerable = Paginate(enumerable);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _innerEnumerable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _innerEnumerable.GetEnumerator();
        }

        public IEnumerable<T> Paginate(IEnumerable<T> enumerable)
        {
            return enumerable.Skip((PagingPropeties.PageIndex - 1)
                * PagingPropeties.PageSize).Take(PagingPropeties.PageSize);
        }
    }
}