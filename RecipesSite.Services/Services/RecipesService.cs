using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    class RecipesService
    {
        private RecipesRepository _repo;

        public RecipesService()
        {
            _repo = new RecipesRepository();
        }

        public List<Recipes> GetAll()
        {
            return null;
        }

        public Recipes GetById(int id)
        {
            return null;
        }

        public void Add(Recipes recipes)
        {

        }

        public void Update(Recipes recipes)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
