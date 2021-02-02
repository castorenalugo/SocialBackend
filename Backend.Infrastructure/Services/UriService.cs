using System;
using Backend.Domain.QueryFilters;
using Backend.Infrastructure.Interfaces;

namespace Backend.Infrastructure.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetPostPaginationUri(PostQueryFilter filter, string actionURL)
        {
            string baseUrl = $"{_baseUri}{actionURL}";
            return new Uri(baseUrl);
        }
    }
}
