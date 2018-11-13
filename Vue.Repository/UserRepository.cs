using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Vue.Domain.Models;
using Vue.Domain.Repositories;
using Vue.Entity;
using Vue.Entity.Entities;

namespace Vue.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly VueContext _context;

        public UserRepository(VueContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string email)
        {
            return _context.User.SingleOrDefault(x => x.Email == email);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User;
        }

        public User GetById(string id)
        {
            return _context.User.Find(id);
        }

        public bool Any(Expression<Func<User, bool>> predicate)
        {
            return _context.User.Any(predicate);
        }

        public int Add(User user)
        {
            _context.User.Add(user);
            return _context.SaveChanges();
        }

        public int Update(User user)
        {
            _context.User.Update(user);
            return _context.SaveChanges();
        }

        public int Remove(User user)
        {
            _context.User.Remove(user);
            return _context.SaveChanges();
        }
    }
}
