using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    class IngredientsService
    {
        private IngredientsRepository _repo;

        public IngredientsService()
        {
            _repo = new IngredientsRepository();
        }

        public List<Ingredients> GetAll()
        {
            return null;
        }

        public Ingredients GetById(int id)
        {
            return null;
        }

        public void Add(Ingredients ingredients)
        {

        }

        public void Update(Ingredients ingredients)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
