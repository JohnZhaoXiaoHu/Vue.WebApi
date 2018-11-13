using System;
using System.Collections.Generic;
using System.Text;
using Vue.Domain.Models;
using Vue.Entity.Entities;

namespace Vue.Domain.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        IEnumerable<User> GetAll();
        User GetById(string id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(string id);
    }
}
