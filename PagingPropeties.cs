namespace FabioGilberto.Paging
{
    public class PagingPropeties
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get => GetTotalPages(); }
        public bool HasNextPage { get => GetHasNextPage(); }
        public bool HasPreviousPage { get => GetHasPreviousPage(); }

        public PagingPropeties(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        private int GetTotalPages()
        {
            return (int)Math.Ceiling(TotalCount / (double)PageSize);
        }

        private bool GetHasNextPage()
        {
            return PageIndex < TotalPages;
        }

        private bool GetHasPreviousPage()
        {
            return PageIndex > 1;
        }
    }
}
