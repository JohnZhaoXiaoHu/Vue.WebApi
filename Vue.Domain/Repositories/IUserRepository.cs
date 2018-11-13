using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vue.Domain.Models;
using Vue.Entity.Entities;

namespace Vue.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        IEnumerable<User> GetAll();
        User GetById(string id);
        bool Any(Expression<Func<User, bool>> predicate);
        int Add(User user);
        int Update(User user);
        int Remove(User user);
    }
}
