using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WATERLINE.Entities;
using WATERLINE.Services.DTOs.Users;

namespace WATERLINE.Services.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<User> Insert(string by, UserDto user);
        User GetUser(Expression<Func<User, bool>> predicate);
        List<User> GetUsers(Expression<Func<User, bool>> predicate);
        Task Update(string by, User old, User user);
        Task Delete(string by, User user);
    }
}
