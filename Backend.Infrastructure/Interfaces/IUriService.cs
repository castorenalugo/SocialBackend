using System;
using Backend.Domain.QueryFilters;

namespace Backend.Infrastructure.Interfaces
{
    public interface IUriService
    {
        Uri GetPostPaginationUri(PostQueryFilter filter, string actionURL);
    }
}
