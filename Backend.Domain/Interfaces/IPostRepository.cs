using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(int id);
        Task InsertPost(Post post);
    }
}
