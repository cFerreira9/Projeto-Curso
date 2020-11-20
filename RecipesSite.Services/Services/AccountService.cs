using RecipesSite.Data.Repositories;
using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    class AccountService
    {
        private AccountRepository _repo;

        public AccountService()
        {
            _repo = new AccountRepository();
        }

        public List<Account> GetAll()
        {
            return null;
        }

        public Account GetById(int id)
        {
            return null;
        }

        public void Add(Account account)
        {

        }

        public void Update(Account account)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
