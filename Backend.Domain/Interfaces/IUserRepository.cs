using System;
using System.Threading.Tasks;
using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
    }
}
