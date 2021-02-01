using System;
using System.Threading.Tasks;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;

namespace Backend.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }

        IRepository<User> UserRepository { get; }

        IRepository<Comment> CommentRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
