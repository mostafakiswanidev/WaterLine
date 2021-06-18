using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WATERLINE.DataAccess.Repositories.Interfaces;
using WATERLINE.Entities;
using WATERLINE.Services.DTOs.Users;
using WATERLINE.Services.Repositories.Interfaces;

namespace WATERLINE.Services.Repositories.Implemntations
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        public UsersRepository(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        private string PasswordEncryptor(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public async Task Delete(string by, User user) => await _repository.DeleteAsync(by, user);
        public async Task Update(string by, User old, User user) => await _repository.UpdateAsync(by, old,user);
        public User GetUser(Expression<Func<User, bool>> predicate) => _repository.FindByCondition(predicate);
        public List<User> GetUsers(Expression<Func<User, bool>> predicate) => _repository.FindAllByCondition(predicate);

        public async Task<User> Insert(string by, UserDto user)
        {
            if (GetUser(x => x.Username == user.Username) != null)
                return null;

            var createdUser = _mapper.Map<User>(user);

            createdUser.Password = PasswordEncryptor(user.Password);

            return await _repository.InsertAsync(by, createdUser);
        }
    }
}
