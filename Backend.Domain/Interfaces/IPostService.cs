using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Domain.CustomEntities;
using Backend.Domain.Entities;
using Backend.Domain.QueryFilters;

namespace Backend.Domain.Interfaces
{
    public interface IPostService
    {
        PagedList<Post> GetPosts(PostQueryFilter filters);
        Task<Post> GetPost(int id);
        Task InsertPost(Post post);
        Task<bool> UpdatePost(Post post);
        Task<bool> DeletePost(int id);
    }
}
