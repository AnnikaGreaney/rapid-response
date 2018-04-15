using System.Collections.Generic;

namespace RapidResponse.infrastructure.Collections
{
    public interface IPagedList<T> : IList<T>
    {
        int PageCount { get; }
        int TotalItemCount { get; }
        int PageIndex { get; }
        int PageNumberDisplayedToUser { get; }
        int PageSize { get; }
        int PageFirstItemIndex { get; }
        int PageLastItemIndex { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
        bool IsFirstPage { get; }
        bool IsLastPage { get; }
    }
}
