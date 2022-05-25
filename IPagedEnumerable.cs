namespace FabioGilberto.Paging
{
    public interface IPagedEnumerable<T> : IPageable, IEnumerable<T>
    {
    }
}