using RecipesSite.Data.Repositories;
using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    class CategoryService
    {
        private CategoryRepository _repo;

        public CategoryService()
        {
            _repo = new CategoryRepository();
        }

        public List<Category> GetAll()
        {
            return null;
        }

        public Category GetById(int id)
        {
            return null;
        }

        public void Add(Category category)
        {

        }

        public void Update(Category category)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
