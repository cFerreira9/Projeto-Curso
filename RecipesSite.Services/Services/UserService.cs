using RecipesSite.Data.Repositories;
using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    public class UserService
    {
        private UserRepository _repo;

        public UserService()
        {
           _repo = new UserRepository();
        }

        public List<User> GetAll()
        {
            return _repo.GetAll();
        }

        public User GetById(int id)
        {
            User user = _repo.GetById(id);
            user.Password = "";
            return user;
        }

        public void Add(User user)
        {
            string passwordHashed = passwordHash(user.Password);
            user.Password = passwordHashed;

            _repo.Add(user);
        }

        public void Update(User user)
        {
            string passwordHashed = passwordHash(user.Password);
            user.Password = passwordHashed;

            _repo.Update(user);
        }

        public void Remove(int id)
        {
            User user = _repo.GetById(id);
            user.IsActive = false;
            _repo.Update(user);
        }

        private string passwordHash(string password)
        {
            return password;
        }
    }
}
