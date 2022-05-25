using System.Text.Json.Serialization;

namespace FabioGilberto.Paging
{
    public interface IPageable
    {
        [JsonIgnore]
        PagingPropeties PagingPropeties { get; }
    }
}
