using System;
using System.Collections.Generic;
using System.Linq;

namespace RapidResponse.infrastructure.Collections
{
    public class PagedList<T> : List<T>, IPagedList<T>
    {
        public PagedList(IEnumerable<T> source, int index, int pageSize)
            : this(source, index, pageSize, null, false) { }

        public PagedList(IQueryable<T> source, int index, int pageSize)
            : this(source, index, pageSize, null, false) { }

        public PagedList(IEnumerable<T> source, int index, int pageSize, int? totalCount)
            : this(source, index, pageSize, totalCount, false) { }

        public PagedList(IQueryable<T> source, int index, int pageSize, int? totalCount)
            : this(source, index, pageSize, totalCount, false) { }

        public PagedList(IEnumerable<T> source, int index, int pageSize, int? totalCount, bool prePaged)
        {
            Initialize(source.AsQueryable(), index, pageSize, totalCount, prePaged);
        }

        public PagedList(IQueryable<T> source, int index, int pageSize, int? totalCount, bool prePaged)
        {
            Initialize(source, index, pageSize, totalCount, prePaged);
        }

        #region IPagedList Members

        public int PageCount { get; private set; }
        public int TotalItemCount { get; private set; }
        public int PageIndex { get; private set; }
        public int PageNumberDisplayedToUser { get { return PageIndex + 1; } }
        public int PageSize { get; private set; }
        public bool HasPreviousPage { get; private set; }
        public bool HasNextPage { get; private set; }
        public bool IsFirstPage { get; private set; }
        public bool IsLastPage { get; private set; }

        public int PageFirstItemIndex
        {
            get
            {
                if (TotalItemCount == 0)
                    return 0;
                return PageIndex * PageSize + 1;
            }
        }

        public int PageLastItemIndex
        {
            get
            {
                if (TotalItemCount == 0)
                    return 0;
                else if (PageNumberDisplayedToUser * PageSize > TotalItemCount)
                    return TotalItemCount;
                else
                    return PageNumberDisplayedToUser * PageSize;
            }
        }

        #endregion

        protected void Initialize(IQueryable<T> source, int index, int pageSize, int? totalCount, bool prePaged)
        {
            //### argument checking
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("PageIndex cannot be below 0.");
            }
            if (pageSize < 1)
            {
                throw new ArgumentOutOfRangeException("PageSize cannot be less than 1.");
            }

            //### set source to blank list if source is null to prevent exceptions
            if (source == null)
            {
                source = new List<T>().AsQueryable();
            }

            //### set properties
            if (totalCount.HasValue)
            {
                TotalItemCount = totalCount.Value;
            }
            else
            {
                TotalItemCount = source.Count();
            }
            PageSize = pageSize;
            PageIndex = index;
            if (TotalItemCount > 0)
            {
                PageCount = (int)Math.Ceiling(TotalItemCount / (double)PageSize);
            }
            else
            {
                PageCount = 0;
            }
            HasPreviousPage = (PageIndex > 0);
            HasNextPage = (PageIndex < (PageCount - 1));
            IsFirstPage = (PageIndex <= 0);
            IsLastPage = (PageIndex >= (PageCount - 1));

            if (prePaged)
            {
                AddRange(source.ToList());
            }
            else
            {
                //### add items to internal list
                if (TotalItemCount > 0)
                {
                    AddRange(source.Skip((index) * pageSize).Take(pageSize).ToList());
                }
            }
        }
    }
}