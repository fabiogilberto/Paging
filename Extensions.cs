namespace FabioGilberto.Paging
{
    public static class Extensions
    {
        public static IPagedQueryable<T> AsPagedQueryable<T>(this IQueryable<T> query, PagingPropeties pagingPropeties)
        {
            return new PagedQueryable<T>(query, pagingPropeties);
        }

        public static IPagedEnumerable<T> AsPagedEnumerable<T>(this IEnumerable<T> enumerable, PagingPropeties pagingPropeties)
        {
            return new PagedEnumerable<T>(enumerable, pagingPropeties);
        }
    }
}