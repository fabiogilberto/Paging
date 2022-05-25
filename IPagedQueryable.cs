namespace FabioGilberto.Paging
{
    public interface IPagedQueryable<T> : IQueryable<T>, IPagedEnumerable<T>, IPageable
    {
    }
}