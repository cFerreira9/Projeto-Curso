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
            return _repo.GetById(id);
        }

        public User GetUserByRecipeID(int id)
        {
            return _repo.GetUserByRecipeID(id);
        }

        public void Add(User user, string membershipUsername)
        {
            user.MemberShipUsername = membershipUsername;
            _repo.Add(user);
        }

        public void UpdateByAdmin(User user)
        {
            _repo.UpdateByAdmin(user);
        }

        public void UpdateByClient(User user)
        {
            _repo.UpdateByClient(user);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }

        public List<User> BlockedUsers()
        {
            return _repo.BlockedUsers();
        }

        public void BlockUnblockUser(int id, bool block)
        {
            try
            {
                _repo.BlockUnBlockUser(id, block);
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao bloquear utilizador.");
            }
        }
    }
}
